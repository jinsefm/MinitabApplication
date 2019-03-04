using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MinitabApplication.Handler
{
    class MtbHandler
    {
        private string controlId { get; set; }

        private DataTable dt=new DataTable();

        private int endColumn { get; set; }//dt原数据总列数
        private string beginCommand { get; set; }

        private int ruleTotalCount = 0;//规则总数

        private int ruleFirstFourCount = 0;//minitab前四条规则选中数

        private string imgDir = System.AppDomain.CurrentDomain.BaseDirectory;

        public MtbHandler(string ControlID,DataTable data,string beginCommand)
        {
            this.controlId = ControlID;
            this.dt = data;
            this.endColumn = dt.Columns.Count;
            this.beginCommand = beginCommand;
        }

        private string GetVarCommands(string chartType)
        {
            string commands = string.Empty;
            if (chartType == "Capability")
            {
                commands = "Name C" + (endColumn + 1) + " \"LSL\" C" + (endColumn + 2)
                + " \"Target\" C" + (endColumn + 3) + " \"USL\" C" + (endColumn + 4)
                + " \"平均值\" C" + (endColumn + 5) + " \"样本N\" C" + (endColumn + 6) + " \"WStDev\" C" + (endColumn + 7)
                + " \"OStDev\" C" + (endColumn + 8) + " \"Cp\" C" + (endColumn + 9)
                + " \"CPL\" C" + (endColumn + 10) + " \"CPU\" C" + (endColumn + 11)
                + " \"Cpk\" C" + (endColumn + 12) + " \"Cpm\" C" + (endColumn + 13)
                + " \"Pp\" C" + (endColumn + 14) + " \"PPL\" C" + (endColumn + 15)
                + " \"PPU\" C" + (endColumn + 16) + " \"Ppk\"";
            }else
            {
                commands = "Name C" + (endColumn + 1) + " \"平均值\" C" + (endColumn + 2) + " \"标准差\" C" + (endColumn + 3)
                + " \"绘制的点1\" C" + (endColumn + 4) + " \"绘制的点2\" C" + (endColumn + 5) + " \"中心线值1\" C" + (endColumn + 6)
                + " \"中心线值2\" C" + (endColumn + 7) + " \"控制限制值1\" C" + (endColumn + 8)
                + " \"控制限制值2\" C" + (endColumn + 9) + " \"控制限制值3\" C" + (endColumn + 10) + " \"控制限制值4\" C" + (endColumn + 11)
                + " \"子组大小\" ";
                for (int i = 0; i < ruleTotalCount + ruleFirstFourCount; i++)
                {
                    commands += " C" + (endColumn + 12 + i) + " \"检验结果"+(i+1)+"\"";
                }
                commands += ".";
            }
            return commands;
        }

        private string GetExcuteCommands(string chartType, Dictionary<string, string> rules)
        {
            string commands = string.Empty;
            if (chartType == "Capability")
            {

                commands = beginCommand;                 
                
                commands +="; Lspec " + rules["LSL"]
                    + "; Uspec " + rules["USL"]
                    + "; Pooled; AMR; UnBiased; OBiased; Target " + rules["Target"]
                    + "; Toler 6; Within; Overall"
                    + "; LSL 'LSL';STarget  'Target';USL  'USL';Mean  '平均值';N  '样本N'"
                    + "; SDT  'WStDev';SDO  'OStDev'"
                    + "; CP  'Cp';CPL  'CPL';CPU  'CPU';CPK  'Cpk';CPM 'Cpm'"
                    + "; PP  'Pp';PPL  'PPL';PPU  'PPU';PPK  'Ppk'"
                    + "; Title" + " \"" + this.controlId + " Capability:LSL=" + rules["LSL"] + ",USL=" + rules["USL"] + "\""
                    + "; CStat.";
            }
            else if (chartType.Contains("Chart"))
            {

                commands = beginCommand;

                commands += ";"+ this.checkRule(rules) //"; Test 1 2 3; DefTest 2 7 3 7"
                    + ";Title" + " \"" + this.controlId + " " + chartType + "\""
                    + ";Location '平均值'"
                    + ";Variation '标准差'"
                    + ";PPoints '绘制的点1' - '绘制的点2'"
                    + ";CenLine '中心线值1' - '中心线值2'"
                    + ";ConLimits '控制限制值1' - '控制限制值4'";
                if (chartType != "IMRChart")
                    commands += ";SampSize '子组大小'";
                if (this.ruleTotalCount < 1)
                    commands += ".";
                else
                {
                    if (this.ruleFirstFourCount < 1)
                        commands += ";TResults '检验结果1'.";
                    else
                        commands += ";TResults '检验结果1' - '检验结果"+(ruleFirstFourCount+ruleTotalCount)+"'.";
                }
            }
            return commands;
        }

        public Dictionary<string, object> MtbAnalysis(string chartType,Dictionary<string,string> rules) 
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("Mtb"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {}
            System.IO.FileInfo imgFile = new System.IO.FileInfo(imgDir + this.controlId + "_" + chartType + ".PNG");
            if (imgFile.Exists) imgFile.Delete();

            Mtb.Application MtbApp = new Mtb.Application();
            Dictionary<string, object> resultObject = new Dictionary<string, object>();
            try
            {
                MtbApp.UserInterface.Visible = false;
                Mtb.Project MtbProj = MtbApp.ActiveProject;

                Mtb.Columns MtbColumns = MtbProj.ActiveWorksheet.Columns;
                //加载dt所有数据到mtb
                for (int i = 0; i < endColumn; i++)
                {
                    Mtb.Column MtbColumn1 = MtbColumns.Add(null, null, 1);
                    ArrayList columnData = new ArrayList();
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        if (dt.Rows[j][i].ToString().Length < 1)
                            columnData.Add(DBNull.Value);
                        else
                            columnData.Add(dt.Rows[j][i]);
                    }
                    MtbColumn1.SetData(columnData.ToArray());
                }

                int rawColumnCount = MtbColumns.Count;

                //Minitab 控制图 or 能力分析命令。
                //命令先生成，先调用checkRule()方法检查规则数量，以及对应生成的检验结果列数
                string execAnalysis = this.GetExcuteCommands(chartType, rules);

                //Minitab 分析结果存储列命令
                string varCommand = this.GetVarCommands(chartType);

                if (!string.IsNullOrEmpty(varCommand))
                    MtbProj.ExecuteCommand(varCommand);                
                if (!string.IsNullOrEmpty(execAnalysis))
                    MtbProj.ExecuteCommandAsync(execAnalysis);

                Mtb.Output MtbOut = null;
                 try {
                     MtbOut = MtbProj.Commands.Item(MtbProj.Commands.Count).Outputs.Item(1);
                     Console.WriteLine("Normal output!Normal output!Normal output!");
                 }
                 catch(Exception ex)
                {
                    MtbOut = MtbProj.Commands.Item(MtbProj.Commands.Count).Outputs.Item(1);
                    Console.WriteLine("Unormal output!Unormal output!Unormal output!");
                }

                //Minitab 图形保存
                Mtb.Graph MtbGraph = MtbOut.Graph;
                MtbGraph.SaveAs(imgDir +  this.controlId + "_" + chartType, true, Mtb.MtbGraphFileTypes.GFPNGHighColor, 790, 500);
               
                //Minitab 工作区表保存
                Mtb.Worksheet MtbSheet = MtbProj.ActiveWorksheet;
                MtbSheet.SaveAs(imgDir +  this.controlId + "_" + chartType, true);

                for (int i = 1; i <= MtbSheet.Columns.Count; i++)
                {
                    resultObject.Add(MtbSheet.Columns.Item(i).Name, MtbSheet.Columns.Item(i).GetData());
                }
                if (chartType.Contains("Chart"))
                {
                    resultObject.Add("RuleOut",MtbProj.Commands.OutputDocument.Text);
                }
                MtbProj.Delete();
                MtbApp.Quit();
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { MtbApp.Quit(); }
            return resultObject;
        }

        public string checkRule(Dictionary<string,string> rules) 
        {
            string RuleCommand="Test ";//Test 后面跟着被选中的规则编号
            string DiffRule="DefTest ";//DefTest 后面跟着规则编号与默认K值不同的数
            ruleTotalCount = 0;//规则总数
            ruleFirstFourCount = 0;//前四条规则选中数
            foreach(string s in rules.Keys)
            {
                if (s == "1" )
                {
                    RuleCommand += s + " ";
                    if (rules["1"] != "3") DiffRule += "1 " + rules["1"] + " ";
                    ruleTotalCount++;
                    ruleFirstFourCount++;
                }
                else if (s == "2")
                {
                    RuleCommand += s + " ";
                    if (rules["2"] != "9") DiffRule += "2 " + rules["2"] + " ";
                    ruleTotalCount++;
                    ruleFirstFourCount++;
                }
                else if (s == "3")
                {
                    RuleCommand += s + " ";
                    if (rules["3"] != "6") DiffRule += "3 " + rules["3"] + " ";
                    ruleTotalCount++;
                    ruleFirstFourCount++;
                }
                else if (s == "4")
                {
                    RuleCommand += s + " ";
                    if (rules["4"] != "14") DiffRule += "4 " + rules["4"] + " ";
                    ruleTotalCount++;
                    ruleFirstFourCount++;
                }
                else if (s == "5")
                {
                    RuleCommand += s + " ";
                    if (rules["5"] != "2") DiffRule += "5 " + rules["5"] + " ";
                    ruleTotalCount++;
                }
                else if (s == "6")
                {
                    RuleCommand += s + " ";
                    if (rules["6"] != "4") DiffRule += "6 " + rules["6"] + " ";
                    ruleTotalCount++;
                }
                else if (s == "7")
                {
                    RuleCommand += s + " ";
                    if (rules["7"] != "15") DiffRule += "7 " + rules["7"] + " ";
                    ruleTotalCount++;
                }
                else if (s == "8")
                {
                    RuleCommand += s + " ";
                    if (rules["8"] != "8") DiffRule += "8 " + rules["8"] + " ";
                    ruleTotalCount++;
                }
            }
            if (RuleCommand.Length > 5)
            {
                RuleCommand = RuleCommand.Remove(RuleCommand.Length - 1, 1);
                if (DiffRule.Length > 9)
                {
                    DiffRule = DiffRule.Remove(DiffRule.Length - 1, 1);
                    RuleCommand = RuleCommand + "; " + DiffRule + ";";
                }
            }
            else
                RuleCommand = string.Empty;
            return RuleCommand;
        }
    }
}
