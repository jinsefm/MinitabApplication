using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MinitabApplication.Handler;

namespace MinitabApplication.Control
{
    public partial class ControlChart : UserControl
    {
        private Dictionary<string, object> resultObject = new Dictionary<string, object>();
        private string chartType = string.Empty;

        public ControlChart()
        {
            InitializeComponent();
        }

        public ControlChart(Dictionary<string, object> resultObject,string chartType)
        {
            InitializeComponent();
            this.resultObject = resultObject;
            this.chartType = chartType;

        }

        public void DrawImage(string imgpath)
        {
            try
            {
                System.IO.FileInfo file = new System.IO.FileInfo(imgpath);
                if (!file.Exists) return;
                System.IO.FileStream stream = file.OpenRead();
                Image img = Image.FromStream(stream);
                stream.Close();
                this.pBox.Image = img;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisplayResultInfo()
        {
            try
            {
                this.lb_rcl.Text = this.chartType.Substring(1) + this.lb_rcl.Text;
                this.lb_rlcl.Text = this.chartType.Substring(1) + this.lb_rlcl.Text;
                this.lb_rucl.Text = this.chartType.Substring(1) + this.lb_rucl.Text;
                Object subGroup = this.resultObject["子组大小"];
                Object aver = this.resultObject["平均值"];
                Object devation = this.resultObject["标准差"];
                Object CL_X = this.resultObject["中心线值1"];
                Object CL_R = this.resultObject["中心线值2"];
                Object LCL_X = this.resultObject["控制限制值1"];
                Object UCL_X = this.resultObject["控制限制值2"];
                Object LCL_R = this.resultObject["控制限制值3"];
                Object UCL_R = this.resultObject["控制限制值4"];
                Object X_Point = this.resultObject["绘制的点1"];
                Object R_Point = this.resultObject["绘制的点2"];
                Object RuleInfo = this.resultObject["RuleOut"];
                if (aver is double[])
                    this.tbAverage.Text = ((double[])aver)[0].ToString();
                if (devation is double[])
                    this.tbDevation.Text = ((double[])devation)[0].ToString();
                if (CL_X is double[])
                    this.tbX_CL.Text = ((double[])CL_X)[0].ToString();
                if (CL_R is double[])
                    this.tbR_CL.Text = ((double[])CL_R)[0].ToString();
                if (LCL_X is double[])
                    this.tbX_LCL.Text = ((double[])LCL_X)[0].ToString();
                if (UCL_X is double[])
                    this.tbX_UCL.Text = ((double[])UCL_X)[0].ToString();
                if (LCL_R is double[])
                    this.tbR_LCL.Text = ((double[])LCL_R)[0].ToString();
                if (UCL_R is double[])
                    this.tbR_UCL.Text = ((double[])UCL_R)[0].ToString();
                if (subGroup is double[])
                    this.tbSubGroup.Text = ((double[])subGroup)[0].ToString();
                if (RuleInfo is string)
                {
                    this.tbRuleOut.Text = (string)RuleInfo.ToString();
                    if (string.IsNullOrEmpty((string)RuleInfo.ToString()))
                        this.tbRuleOut.Visible = false;
                }

                DataTable dtChart = new DataTable();
                dtChart.Columns.Add("NO", typeof(string));
                 foreach (string key in this.resultObject.Keys)
                {
                    dtChart.Columns.Add(key, typeof(string));
                }
                for (int i = 0; i < ((string[])this.resultObject["C1"]).Length; i++)
                {
                    DataRow row = dtChart.NewRow();
                    row[0] = (i + 1).ToString();
                    dtChart.Rows.Add(row);
                }
                foreach (string key in this.resultObject.Keys)
                {
                    object cur = this.resultObject[key];
                    if (cur is double[])
                    {
                        for (int i = 0; i < ((double[])cur).Length; i++)
                            dtChart.Rows[i][key] = ((double[])cur)[i].ToString();
                    }
                    else if (cur is string[])
                    {
                        for (int i = 0; i < ((string[])cur).Length; i++)
                            dtChart.Rows[i][key] = ((string[])cur)[i];
                    }
                    else
                    {
                        dtChart.Rows[0][key] = cur.ToString();//异常检验的信息
                    }
                }

                if (dtChart.Rows.Count > 0)
                    this.dgvControlData.DataSource = dtChart;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel file (*.xlsx)|*.xls;*.xlsx";
            saveDialog.FileName = this.chartType+DateTime.Now.ToShortDateString();
            saveDialog.AddExtension = true;
            if (saveDialog.ShowDialog() == DialogResult.OK) {
                ExcelHandler er = new ExcelHandler(saveDialog.FileName);
                er.TableToExcel(this.dgvControlData.DataSource as DataTable,pBox.Image);
                MessageBox.Show(saveDialog.FileName,"Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
