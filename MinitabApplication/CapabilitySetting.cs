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
    public partial class CapabilitySetting:Form
    {

        public delegate void OKButtonClickedEventHandler(string chartType,Dictionary<string, string> rules,string beginCommand);
        public event OKButtonClickedEventHandler OKButtonClicked;

        private Dictionary<string, string> spec = new Dictionary<string, string>();//保存规格信息
        private DataTable dealData = new DataTable();
        private List<int> columnIdx = new List<int>();//保存被选中的数据列索引号

        public CapabilitySetting(Dictionary<string, string> spec,DataTable data)
        {
            InitializeComponent();
            this.spec = spec;
            this.dealData = data;
            
                        
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtbSubgroup.Text)) return;
            if (lbSubGroup.Visible && string.IsNullOrEmpty(tbSubGroup.Text)) return;
            if (!lbLSL.Visible && string.IsNullOrEmpty(tbLSL.Text)) return;
            if (!lbTarget.Visible && string.IsNullOrEmpty(tbTarget.Text)) return;
            if (!lbUSL.Visible && string.IsNullOrEmpty(tbUSL.Text)) return;
            string beginCommand = "Numeric " + this.rtbSubgroup.Text + " " + this.rtbSubgroup.Text+".";
            if (cmbData.SelectedItem.ToString().Contains("同一列"))
            {
                beginCommand += "Capa " + this.rtbSubgroup.Text + " " + this.tbSubGroup.Text;                
            }
            else
            {
                beginCommand += "Capa" + "; RSub " + this.rtbSubgroup.Text;                
            }
            this.spec.Clear();
            this.spec.Add("USL",tbUSL.Text);
            this.spec.Add("LSL", tbLSL.Text);
            this.spec.Add("Target", tbTarget.Text);
            this.OKButtonClicked("Capability",this.spec, beginCommand);

            this.Close();
        }

        

        /*子组大小输入提示*/
        #region

        private void tbSubGroup_Click(object sender, EventArgs e)
        {
            if ((sender as TextBox).Name == "tbSubGroup")
            {
                lbSg.Visible = false;
            }
            else if ((sender as TextBox).Name == "tbUSL")
            {
                lbUSL.Visible = false;
            }
            else if ((sender as TextBox).Name == "tbLSL")
            {
                lbLSL.Visible = false;
            }
            else if ((sender as TextBox).Name == "tbTarget")
            {
                lbTarget.Visible = false;
            }
        }


        private void txtRule2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && (e.KeyChar < '0') || (e.KeyChar > '9'))//只允许输入退格键和1-9数字键  
            {
                e.Handled = true;
            }
        }

        private void lbSg_Click(object sender, EventArgs e)
        {
            if ((sender as Label).Name == "lbSg")
            {
                lbSg.Visible = false;
                tbSubGroup.Focus();
            }
            else if ((sender as Label).Name == "lbUSL")
            {
                lbUSL.Visible = false;
                tbUSL.Focus();
            }
            else if ((sender as Label).Name == "lbLSL")
            {
                lbLSL.Visible = false;
                tbLSL.Focus();
            }
            else if ((sender as Label).Name == "lbTarget")
            {
                lbTarget.Visible = false;
                tbTarget.Focus();
            }

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
