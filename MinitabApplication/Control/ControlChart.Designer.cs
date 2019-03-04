namespace MinitabApplication.Control
{
    partial class ControlChart
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.tbX_LCL = new System.Windows.Forms.TextBox();
            this.tbR_LCL = new System.Windows.Forms.TextBox();
            this.tbX_UCL = new System.Windows.Forms.TextBox();
            this.tbR_UCL = new System.Windows.Forms.TextBox();
            this.tbX_CL = new System.Windows.Forms.TextBox();
            this.tbR_CL = new System.Windows.Forms.TextBox();
            this.tbDevation = new System.Windows.Forms.TextBox();
            this.tbSubGroup = new System.Windows.Forms.TextBox();
            this.tbRuleOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_rcl = new System.Windows.Forms.Label();
            this.lb_rucl = new System.Windows.Forms.Label();
            this.lb_rlcl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvControlData = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 508F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 1000);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.tbAverage, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbX_LCL, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbR_LCL, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbX_UCL, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbR_UCL, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbX_CL, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbR_CL, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbDevation, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbSubGroup, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbRuleOut, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lb_rcl, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lb_rucl, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.lb_rlcl, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.dgvControlData, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnExport, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label7, 4, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 438);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(994, 559);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tbAverage
            // 
            this.tbAverage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAverage.Location = new System.Drawing.Point(73, 3);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.ReadOnly = true;
            this.tbAverage.Size = new System.Drawing.Size(172, 21);
            this.tbAverage.TabIndex = 20;
            // 
            // tbX_LCL
            // 
            this.tbX_LCL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbX_LCL.Location = new System.Drawing.Point(817, 3);
            this.tbX_LCL.Name = "tbX_LCL";
            this.tbX_LCL.ReadOnly = true;
            this.tbX_LCL.Size = new System.Drawing.Size(174, 21);
            this.tbX_LCL.TabIndex = 21;
            // 
            // tbR_LCL
            // 
            this.tbR_LCL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbR_LCL.Location = new System.Drawing.Point(817, 31);
            this.tbR_LCL.Name = "tbR_LCL";
            this.tbR_LCL.ReadOnly = true;
            this.tbR_LCL.Size = new System.Drawing.Size(174, 21);
            this.tbR_LCL.TabIndex = 22;
            // 
            // tbX_UCL
            // 
            this.tbX_UCL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbX_UCL.Location = new System.Drawing.Point(569, 3);
            this.tbX_UCL.Name = "tbX_UCL";
            this.tbX_UCL.ReadOnly = true;
            this.tbX_UCL.Size = new System.Drawing.Size(172, 21);
            this.tbX_UCL.TabIndex = 23;
            // 
            // tbR_UCL
            // 
            this.tbR_UCL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbR_UCL.Location = new System.Drawing.Point(569, 31);
            this.tbR_UCL.Name = "tbR_UCL";
            this.tbR_UCL.ReadOnly = true;
            this.tbR_UCL.Size = new System.Drawing.Size(172, 21);
            this.tbR_UCL.TabIndex = 24;
            // 
            // tbX_CL
            // 
            this.tbX_CL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbX_CL.Location = new System.Drawing.Point(321, 3);
            this.tbX_CL.Name = "tbX_CL";
            this.tbX_CL.ReadOnly = true;
            this.tbX_CL.Size = new System.Drawing.Size(172, 21);
            this.tbX_CL.TabIndex = 25;
            // 
            // tbR_CL
            // 
            this.tbR_CL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbR_CL.Location = new System.Drawing.Point(321, 31);
            this.tbR_CL.Name = "tbR_CL";
            this.tbR_CL.ReadOnly = true;
            this.tbR_CL.Size = new System.Drawing.Size(172, 21);
            this.tbR_CL.TabIndex = 26;
            // 
            // tbDevation
            // 
            this.tbDevation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDevation.Location = new System.Drawing.Point(73, 31);
            this.tbDevation.Name = "tbDevation";
            this.tbDevation.ReadOnly = true;
            this.tbDevation.Size = new System.Drawing.Size(172, 21);
            this.tbDevation.TabIndex = 27;
            // 
            // tbSubGroup
            // 
            this.tbSubGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSubGroup.Location = new System.Drawing.Point(73, 59);
            this.tbSubGroup.Name = "tbSubGroup";
            this.tbSubGroup.ReadOnly = true;
            this.tbSubGroup.Size = new System.Drawing.Size(172, 21);
            this.tbSubGroup.TabIndex = 28;
            // 
            // tbRuleOut
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tbRuleOut, 4);
            this.tbRuleOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRuleOut.Location = new System.Drawing.Point(499, 87);
            this.tbRuleOut.Multiline = true;
            this.tbRuleOut.Name = "tbRuleOut";
            this.tbRuleOut.ReadOnly = true;
            this.tableLayoutPanel2.SetRowSpan(this.tbRuleOut, 2);
            this.tbRuleOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRuleOut.Size = new System.Drawing.Size(492, 469);
            this.tbRuleOut.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 30;
            this.label1.Text = "平均值";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(251, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "X CL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(499, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 32;
            this.label3.Text = "X  UCL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(747, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 33;
            this.label4.Text = "X LCL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 28);
            this.label5.TabIndex = 34;
            this.label5.Text = "标准差";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_rcl
            // 
            this.lb_rcl.AutoSize = true;
            this.lb_rcl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_rcl.Location = new System.Drawing.Point(251, 28);
            this.lb_rcl.Name = "lb_rcl";
            this.lb_rcl.Size = new System.Drawing.Size(64, 28);
            this.lb_rcl.TabIndex = 35;
            this.lb_rcl.Text = " CL";
            this.lb_rcl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_rucl
            // 
            this.lb_rucl.AutoSize = true;
            this.lb_rucl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_rucl.Location = new System.Drawing.Point(499, 28);
            this.lb_rucl.Name = "lb_rucl";
            this.lb_rucl.Size = new System.Drawing.Size(64, 28);
            this.lb_rucl.TabIndex = 36;
            this.lb_rucl.Text = " UCL";
            this.lb_rucl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_rlcl
            // 
            this.lb_rlcl.AutoSize = true;
            this.lb_rlcl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_rlcl.Location = new System.Drawing.Point(747, 28);
            this.lb_rlcl.Name = "lb_rlcl";
            this.lb_rlcl.Size = new System.Drawing.Size(64, 28);
            this.lb_rlcl.TabIndex = 37;
            this.lb_rlcl.Text = " LCL";
            this.lb_rlcl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 28);
            this.label9.TabIndex = 38;
            this.label9.Text = "子组大小";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvControlData
            // 
            this.dgvControlData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.dgvControlData, 4);
            this.dgvControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvControlData.Location = new System.Drawing.Point(3, 115);
            this.dgvControlData.Name = "dgvControlData";
            this.dgvControlData.RowTemplate.Height = 23;
            this.dgvControlData.Size = new System.Drawing.Size(490, 441);
            this.dgvControlData.TabIndex = 39;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(251, 87);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(64, 22);
            this.btnExport.TabIndex = 40;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label6, 2);
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 28);
            this.label6.TabIndex = 41;
            this.label6.Text = "控制图数据";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label7, 3);
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(499, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(312, 28);
            this.label7.TabIndex = 42;
            this.label7.Text = "异常检验";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBox
            // 
            this.pBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox.Location = new System.Drawing.Point(3, 3);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(994, 429);
            this.pBox.TabIndex = 1;
            this.pBox.TabStop = false;
            // 
            // ControlChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1000, 1000);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ControlChart";
            this.Size = new System.Drawing.Size(638, 575);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.TextBox tbX_LCL;
        private System.Windows.Forms.TextBox tbR_LCL;
        private System.Windows.Forms.TextBox tbX_UCL;
        private System.Windows.Forms.TextBox tbR_UCL;
        private System.Windows.Forms.TextBox tbX_CL;
        private System.Windows.Forms.TextBox tbR_CL;
        private System.Windows.Forms.TextBox tbDevation;
        private System.Windows.Forms.TextBox tbSubGroup;
        private System.Windows.Forms.TextBox tbRuleOut;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_rcl;
        private System.Windows.Forms.Label lb_rucl;
        private System.Windows.Forms.Label lb_rlcl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvControlData;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
