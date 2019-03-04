using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MinitabApplication
{
    public partial class ControlChartSetting:Form
    {

        public delegate void OKButtonClickedEventHandler(string chartType,Dictionary<string, string> rules,string beginCommand);
        public event OKButtonClickedEventHandler OKButtonClicked;

        private Dictionary<string, string> rules = new Dictionary<string, string>();//保存规则信息
        private DataTable dealData = new DataTable();
        private List<int> columnIdx = new List<int>();//保存被选中的数据列索引号

        public ControlChartSetting(Dictionary<string, string> rules,DataTable data)
        {
            InitializeComponent();
            this.rules = rules;
            this.dealData = data;
            //this.rules_raw = rules;
            this.chkRule1.Checked = false;
            this.chkRule2.Checked = false;
            this.chkRule3.Checked = false;
            this.chkRule4.Checked = false;
            this.chkRule5.Checked = false;
            this.chkRule6.Checked = false;
            this.chkRule7.Checked = false;
            this.chkRule8.Checked = false;
            foreach (string s in rules.Keys)
            {                
                switch (s){
                    case "1":
                        this.chkRule1.Checked = true;
                        if (rules[s] != "3")
                            this.txtRule1.Text = rules[s];
                        break;
                    case "2":
                        this.chkRule2.Checked = true;
                        if (rules[s] != "9")
                            this.txtRule2.Text = rules[s];
                        break;                       
                    case "3":
                        this.chkRule3.Checked = true;
                        if (rules[s] != "6")
                            this.txtRule3.Text = rules[s];
                        break;
                    case "4":
                        this.chkRule4.Checked = true;
                        if (rules[s] != "14")
                            this.txtRule4.Text = rules[s];
                        break;
                    case "5":
                        this.chkRule5.Checked = true;
                        if (rules[s] != "2")
                            this.txtRule5.Text = rules[s];
                        break;
                    case "6":
                        this.chkRule6.Checked = true;
                        if (rules[s] != "4")
                            this.txtRule6.Text = rules[s];
                        break;
                    case "7":
                        this.chkRule7.Checked = true;
                        if (rules[s] != "15")
                            this.txtRule7.Text = rules[s];
                        break;
                    case "8":
                        this.chkRule8.Checked = true;
                         if (rules[s] != "8")
                            this.txtRule8.Text = rules[s];
                         break;
                }
            }            
        }


        private void txtRule2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && (e.KeyChar < '1') || (e.KeyChar > '9'))//只允许输入退格键和1-9数字键  
            {
                e.Handled = true;                
            }  
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.OKButtonClicked(this.rules_raw);
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.chkRule1.Checked && !string.IsNullOrEmpty(this.txtRule1.Text))
            {
                if (!this.rules.ContainsKey("1"))
                    this.rules.Add("1", this.txtRule1.Text);
                else
                    rules["1"] = this.txtRule1.Text;
            }
            else rules.Remove("1");
            if (this.chkRule2.Checked && !string.IsNullOrEmpty(this.txtRule2.Text))
            {
                if (!this.rules.ContainsKey("2"))
                    this.rules.Add("2", this.txtRule2.Text);
                else
                    rules["2"] = this.txtRule2.Text;
            }
            else rules.Remove("2");
            if (this.chkRule3.Checked && !string.IsNullOrEmpty(this.txtRule3.Text))
            {
                if (!this.rules.ContainsKey("3"))
                    this.rules.Add("3", this.txtRule3.Text);
                else
                    rules["3"] = this.txtRule3.Text;
            }
            else rules.Remove("3");
            if (this.chkRule4.Checked && !string.IsNullOrEmpty(this.txtRule4.Text))
            {
                if (!this.rules.ContainsKey("4"))
                    this.rules.Add("4", this.txtRule4.Text);
                else
                    rules["4"] = this.txtRule4.Text;
            }
            else rules.Remove("4");
            if (this.chkRule5.Checked && !string.IsNullOrEmpty(this.txtRule5.Text))
            {
                if (!this.rules.ContainsKey("5"))
                    this.rules.Add("5", this.txtRule5.Text);
                else
                    rules["5"] = this.txtRule5.Text;
            }
            else rules.Remove("5");
            if (this.chkRule6.Checked && !string.IsNullOrEmpty(this.txtRule6.Text))
            {
                if (!this.rules.ContainsKey("6"))
                    this.rules.Add("6", this.txtRule6.Text);
                else
                    rules["6"] = this.txtRule6.Text;
            }
            else rules.Remove("6");
            if (this.chkRule7.Checked && !string.IsNullOrEmpty(this.txtRule7.Text))
            {
                if (!this.rules.ContainsKey("7"))
                    this.rules.Add("7", this.txtRule7.Text);
                else
                    rules["7"] = this.txtRule7.Text;
            }
            else rules.Remove("8");
            if (this.chkRule8.Checked && !string.IsNullOrEmpty(this.txtRule8.Text))
            {
                if (!this.rules.ContainsKey("8"))
                    this.rules.Add("8", this.txtRule8.Text);
                else
                    rules["8"] = this.txtRule8.Text;
            }
            else rules.Remove("8");

            string beginCommand = "Numeric " + this.rtbSubgroup.Text + " " + this.rtbSubgroup.Text+".";
            if (cmbData.SelectedItem.ToString().Contains("同一列"))
            {
                beginCommand += this.cmbChart.Text + " " + this.rtbSubgroup.Text + " " + this.tbSubGroup.Text;                
            }
            else
            {
                beginCommand += this.cmbChart.Text + "; RSub " + this.rtbSubgroup.Text;                
            }

            this.OKButtonClicked(this.cmbChart.Text,this.rules, beginCommand);

            this.Close();
        }

        

        /*子组大小输入提示*/
        #region
        private void tbSubGroup_TextChanged(object sender, EventArgs e)
        {
            lbSg.Visible=tbSubGroup.Text.Length<1;
            if (lbSg.Visible)
                lbSg.Focus();
        }

        private void lbSg_Click(object sender, EventArgs e)
        {
            lbSg.Visible = false;
            tbSubGroup.Focus();
        }
        #endregion

        /*数据列设定逻辑*/
        #region

        private void cmbData_SelectedValueChanged(object sender, EventArgs e)
        {
            this.rtbSubgroup.Text = string.Empty;
            if (cmbData.SelectedItem.ToString().Contains("同一列"))
            {
                this.lbSg.Visible = true;
                this.lbSubGroup.Visible = true;
                this.tbSubGroup.Visible = true;
                this.lsbColumn.SelectionMode = SelectionMode.One;
            }
            else
            {
                this.lbSg.Visible = false;
                this.lbSubGroup.Visible = false;
                this.tbSubGroup.Visible = false;
                this.lsbColumn.SelectionMode = SelectionMode.MultiExtended;
            }
            lsbColumn.Items.Clear();
            int i = 1;
            foreach (DataColumn dc in dealData.Columns)
            {
                string cname = "C" + i.ToString();
                if (Regex.IsMatch(dealData.Rows[0][dc.ColumnName].ToString(), @"^[+-]?\d*[.]?\d*$"))
                    lsbColumn.Items.Add(cname + "   " + dc);
                i++;
            }
        }

        //listbox多选的处理
        private void btnCommit_Click(object sender, EventArgs e)
        {
            this.rtbSubgroup.Text = string.Empty;
            columnIdx = new List<int>();
            string appendText=string.Empty;
            for (int i = 0; i < lsbColumn.SelectedIndices.Count;i++ )
            {
                columnIdx.Add(lsbColumn.SelectedIndices[i]);
                string a = lsbColumn.Items[lsbColumn.SelectedIndices[i]].ToString().Split(' ')[0];
                if (i == 0)
                    appendText += a;
                else if (i > 0)
                {
                    string b = lsbColumn.Items[lsbColumn.SelectedIndices[i - 1]].ToString().Split(' ')[0];
                    if (lsbColumn.SelectedIndices[i] - lsbColumn.SelectedIndices[i - 1] == 1)
                    {
                        if (!appendText.EndsWith("-"))
                            appendText += "-";
                        if (i == lsbColumn.SelectedIndices.Count - 1)
                            appendText += a;
                    }
                    else {
                        if (!appendText.Contains(b))
                            appendText += b;
                        appendText += " " + a;
                    }
                }
            }
            this.rtbSubgroup.Text = appendText;
        }

        //listbox单选双击
        private void lsbColumn_DoubleClick(object sender, EventArgs e)
        {
            if (!columnIdx.Contains(lsbColumn.SelectedIndex))
            {
                columnIdx.Add(lsbColumn.SelectedIndex);
                this.rtbSubgroup.AppendText(" " + lsbColumn.SelectedItem.ToString().Split(' ')[0]);
            }
        }
        #endregion



    }
}
