using MinitabApplication.Handler;
using MinitabApplication.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinitabApplication
{
    public partial class  MinitabReference : Form
    {
        Dictionary<string, DataTable> MapData = new Dictionary<string, DataTable>();
        Dictionary<string, string> rule = new Dictionary<string, string>() { };//存放规则信息
        Dictionary<string, string> spec = new Dictionary<string, string>() { };//存放规格信息
        string selectKey = string.Empty;//TabControl被选中的选项卡名
        public MinitabReference()
        {
            InitializeComponent();
            this.tbControl.TabPages.Clear();
            this.rule.Add("1", "3");//Minitab控制图默认1点超出3sigma规则
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            this.tbControl.TabPages.Clear();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter ="Excel file (*.xlsx)|*.xls;*.xlsx";
            dialog.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory;//Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            dialog.Title = "请选择规范的数据文件";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ExcelHandler excelHandler = new ExcelHandler(dialog.FileName);
                MapData = excelHandler.ExcelToTable();
                foreach (KeyValuePair<string, DataTable> kv in MapData)
                {
                    this.tbControl.TabPages.Add(kv.Key, kv.Key);
                    TableLayoutPanel tb1 = new TableLayoutPanel();
                    this.tbControl.TabPages[kv.Key].Controls.Add(tb1);
                    tb1.Dock = DockStyle.Fill;
                    DataGridView grdUpload = new DataGridView();
                    grdUpload.DataSource = kv.Value;
                    grdUpload.Dock = DockStyle.Fill;
                    tb1.Controls.Add(grdUpload, 0, 0);
                    grdUpload.ReadOnly = true;
                }
            }
        }
         
        private void tsmiControlChart_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.tbControl.TabPages.Count < 1) return;
                selectKey = this.tbControl.SelectedTab.Text.Contains("_") ? this.tbControl.SelectedTab.Text.Split('_')[0] : this.tbControl.SelectedTab.Text;
                if (!MapData.ContainsKey(selectKey)) return;
                ControlChartSetting settingWindow = new ControlChartSetting(rule, MapData[selectKey]);
                settingWindow.StartPosition = FormStartPosition.CenterParent;
                settingWindow.OKButtonClicked += settingWindow_OKButtonClicked;
                settingWindow.ShowDialog();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void settingWindow_OKButtonClicked(string chartType,Dictionary<string, string> rules,string command)
        {
            try
            {
                showAnalysisResult(chartType, rules, command);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiCability_Click(object sender, EventArgs e)
        {
            if (this.tbControl.TabPages.Count < 1) return;
            selectKey = this.tbControl.SelectedTab.Text.Contains("_") ? this.tbControl.SelectedTab.Text.Split('_')[0] : this.tbControl.SelectedTab.Text;
            if (!MapData.ContainsKey(selectKey)) return;
            CapabilitySetting capabilitySetting = new CapabilitySetting(spec, MapData[selectKey]);
            capabilitySetting.StartPosition = FormStartPosition.CenterParent;
            capabilitySetting.OKButtonClicked+=capabilitySetting_OKButtonClicked;
            capabilitySetting.ShowDialog();
        }

        private void capabilitySetting_OKButtonClicked(string chartType, Dictionary<string, string> spec, string command)
        {
            try
            {
                showAnalysisResult(chartType,spec,command);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showAnalysisResult(string chartType, Dictionary<string, string> ruleSpec, string command)
        {
            MtbHandler mtbExcute = new MtbHandler(selectKey, MapData[selectKey], command);

            Dictionary<string, object> result = mtbExcute.MtbAnalysis(chartType, ruleSpec);

            string key = selectKey + "_" + chartType;

            if (this.tbControl.TabPages.ContainsKey(key))
                this.tbControl.TabPages.Remove(this.tbControl.TabPages[key]);

            this.tbControl.TabPages.Add(key, key);

            if (chartType == "Capability")
            {
                Capability analysisResult = new Capability(result);
                this.tbControl.TabPages[key].Controls.Add(analysisResult);
                analysisResult.Dock = DockStyle.Fill;
                analysisResult.DisplayResultInfo();
                analysisResult.DrawImage(System.AppDomain.CurrentDomain.BaseDirectory + selectKey + "_" + chartType + ".PNG");
            }
            else {                
                ControlChart analysisResult = new ControlChart(result, chartType);
                this.tbControl.TabPages[key].Controls.Add(analysisResult);
                analysisResult.Dock = DockStyle.Fill;
                analysisResult.DisplayResultInfo();
                analysisResult.DrawImage(System.AppDomain.CurrentDomain.BaseDirectory + selectKey + "_" + chartType + ".PNG");
            }

            tbControl.TabPages[key].Select();
        
        }

    }
}
