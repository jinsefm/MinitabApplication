namespace MinitabApplication
{
    partial class CapabilitySetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbData = new System.Windows.Forms.ComboBox();
            this.lsbColumn = new System.Windows.Forms.ListBox();
            this.btnCommit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUSL = new System.Windows.Forms.Label();
            this.lbLSL = new System.Windows.Forms.Label();
            this.lbTarget = new System.Windows.Forms.Label();
            this.tbUSL = new System.Windows.Forms.TextBox();
            this.tbLSL = new System.Windows.Forms.TextBox();
            this.tbTarget = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSg = new System.Windows.Forms.Label();
            this.tbSubGroup = new System.Windows.Forms.TextBox();
            this.lbSubGroup = new System.Windows.Forms.Label();
            this.rtbSubgroup = new System.Windows.Forms.RichTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOK, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 311);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cmbData, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lsbColumn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnCommit, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(375, 275);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // cmbData
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cmbData, 2);
            this.cmbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbData.FormattingEnabled = true;
            this.cmbData.Items.AddRange(new object[] {
            "子组观测值位于多列的同一行中",
            "所有观测值均位于同一列中"});
            this.cmbData.Location = new System.Drawing.Point(3, 3);
            this.cmbData.Name = "cmbData";
            this.cmbData.Size = new System.Drawing.Size(369, 20);
            this.cmbData.TabIndex = 0;
            this.cmbData.SelectedValueChanged += new System.EventHandler(this.cmbData_SelectedValueChanged);
            // 
            // lsbColumn
            // 
            this.lsbColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbColumn.FormattingEnabled = true;
            this.lsbColumn.ItemHeight = 12;
            this.lsbColumn.Location = new System.Drawing.Point(3, 28);
            this.lsbColumn.MultiColumn = true;
            this.lsbColumn.Name = "lsbColumn";
            this.lsbColumn.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsbColumn.Size = new System.Drawing.Size(181, 219);
            this.lsbColumn.TabIndex = 1;
            this.lsbColumn.DoubleClick += new System.EventHandler(this.lsbColumn_DoubleClick);
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(3, 253);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 19);
            this.btnCommit.TabIndex = 2;
            this.btnCommit.Text = "选择";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbUSL);
            this.panel1.Controls.Add(this.lbLSL);
            this.panel1.Controls.Add(this.lbTarget);
            this.panel1.Controls.Add(this.tbUSL);
            this.panel1.Controls.Add(this.tbLSL);
            this.panel1.Controls.Add(this.tbTarget);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbSg);
            this.panel1.Controls.Add(this.tbSubGroup);
            this.panel1.Controls.Add(this.lbSubGroup);
            this.panel1.Controls.Add(this.rtbSubgroup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(190, 28);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel2.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(182, 244);
            this.panel1.TabIndex = 3;
            // 
            // lbUSL
            // 
            this.lbUSL.AutoSize = true;
            this.lbUSL.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUSL.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbUSL.Location = new System.Drawing.Point(98, 204);
            this.lbUSL.Name = "lbUSL";
            this.lbUSL.Size = new System.Drawing.Size(33, 13);
            this.lbUSL.TabIndex = 12;
            this.lbUSL.Text = "数字";
            this.lbUSL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbUSL.Click += new System.EventHandler(this.lbSg_Click);
            // 
            // lbLSL
            // 
            this.lbLSL.AutoSize = true;
            this.lbLSL.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbLSL.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbLSL.Location = new System.Drawing.Point(98, 171);
            this.lbLSL.Name = "lbLSL";
            this.lbLSL.Size = new System.Drawing.Size(33, 13);
            this.lbLSL.TabIndex = 11;
            this.lbLSL.Text = "数字";
            this.lbLSL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbLSL.Click += new System.EventHandler(this.lbSg_Click);
            // 
            // lbTarget
            // 
            this.lbTarget.AutoSize = true;
            this.lbTarget.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTarget.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbTarget.Location = new System.Drawing.Point(97, 138);
            this.lbTarget.Name = "lbTarget";
            this.lbTarget.Size = new System.Drawing.Size(33, 13);
            this.lbTarget.TabIndex = 10;
            this.lbTarget.Text = "数字";
            this.lbTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTarget.Click += new System.EventHandler(this.lbSg_Click);
            // 
            // tbUSL
            // 
            this.tbUSL.Location = new System.Drawing.Point(68, 200);
            this.tbUSL.Name = "tbUSL";
            this.tbUSL.Size = new System.Drawing.Size(104, 21);
            this.tbUSL.TabIndex = 9;
            this.tbUSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUSL.Click += new System.EventHandler(this.tbSubGroup_Click);
            // 
            // tbLSL
            // 
            this.tbLSL.Location = new System.Drawing.Point(67, 167);
            this.tbLSL.Name = "tbLSL";
            this.tbLSL.Size = new System.Drawing.Size(104, 21);
            this.tbLSL.TabIndex = 8;
            this.tbLSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLSL.Click += new System.EventHandler(this.tbSubGroup_Click);
            // 
            // tbTarget
            // 
            this.tbTarget.Location = new System.Drawing.Point(67, 134);
            this.tbTarget.Name = "tbTarget";
            this.tbTarget.Size = new System.Drawing.Size(104, 21);
            this.tbTarget.TabIndex = 7;
            this.tbTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTarget.Click += new System.EventHandler(this.tbSubGroup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "规格上限";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "规格下限";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "规格目标";
            // 
            // lbSg
            // 
            this.lbSg.AutoSize = true;
            this.lbSg.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSg.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbSg.Location = new System.Drawing.Point(73, 102);
            this.lbSg.Name = "lbSg";
            this.lbSg.Size = new System.Drawing.Size(94, 13);
            this.lbSg.TabIndex = 3;
            this.lbSg.Text = "数字（2~100）";
            this.lbSg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSg.Click += new System.EventHandler(this.lbSg_Click);
            // 
            // tbSubGroup
            // 
            this.tbSubGroup.Location = new System.Drawing.Point(67, 98);
            this.tbSubGroup.Name = "tbSubGroup";
            this.tbSubGroup.Size = new System.Drawing.Size(105, 21);
            this.tbSubGroup.TabIndex = 2;
            this.tbSubGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSubGroup.Click += new System.EventHandler(this.tbSubGroup_Click);
            this.tbSubGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRule2_KeyPress);
            // 
            // lbSubGroup
            // 
            this.lbSubGroup.AutoSize = true;
            this.lbSubGroup.Location = new System.Drawing.Point(12, 102);
            this.lbSubGroup.Name = "lbSubGroup";
            this.lbSubGroup.Size = new System.Drawing.Size(53, 12);
            this.lbSubGroup.TabIndex = 1;
            this.lbSubGroup.Text = "子组大小";
            // 
            // rtbSubgroup
            // 
            this.rtbSubgroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbSubgroup.Location = new System.Drawing.Point(0, 0);
            this.rtbSubgroup.Name = "rtbSubgroup";
            this.rtbSubgroup.Size = new System.Drawing.Size(182, 74);
            this.rtbSubgroup.TabIndex = 0;
            this.rtbSubgroup.Text = "";
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Location = new System.Drawing.Point(303, 284);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 24);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // CapabilitySetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 311);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CapabilitySetting";
            this.Text = "Capability设定";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cmbData;
        private System.Windows.Forms.ListBox lsbColumn;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSg;
        private System.Windows.Forms.TextBox tbSubGroup;
        private System.Windows.Forms.Label lbSubGroup;
        private System.Windows.Forms.RichTextBox rtbSubgroup;
        private System.Windows.Forms.TextBox tbUSL;
        private System.Windows.Forms.TextBox tbLSL;
        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.Label lbUSL;
        private System.Windows.Forms.Label lbLSL;
        private System.Windows.Forms.Label lbTarget;


    }
}