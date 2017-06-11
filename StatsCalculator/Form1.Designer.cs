namespace StatsCalculator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalExpCost = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddAttribute = new System.Windows.Forms.Button();
            this.nddLevel = new System.Windows.Forms.NumericUpDown();
            this.dgvAttributes = new System.Windows.Forms.DataGridView();
            this.dgvReqs = new System.Windows.Forms.DataGridView();
            this.btnAddPreReq = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSkillExp = new System.Windows.Forms.Label();
            this.lblAttributeExp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAddAttribute = new System.Windows.Forms.Label();
            this.txtAddAttribute = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.nupCurLevel = new System.Windows.Forms.NumericUpDown();
            this.lblCurLevel = new System.Windows.Forms.Label();
            this.Attr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRowAttribute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCreateMult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nddLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttributes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReqs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCurLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(186, 210);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(81, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate Total";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Total Exp";
            // 
            // lblTotalExpCost
            // 
            this.lblTotalExpCost.AutoSize = true;
            this.lblTotalExpCost.Location = new System.Drawing.Point(253, 194);
            this.lblTotalExpCost.Name = "lblTotalExpCost";
            this.lblTotalExpCost.Size = new System.Drawing.Size(13, 13);
            this.lblTotalExpCost.TabIndex = 20;
            this.lblTotalExpCost.Text = "0";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(185, 87);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(67, 13);
            this.lblTarget.TabIndex = 23;
            this.lblTarget.Text = "Target Level";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(24, 12);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(101, 23);
            this.btnImport.TabIndex = 24;
            this.btnImport.Text = "Import Character";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(131, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 23);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save Character";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(394, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Attributes";
            // 
            // btnAddAttribute
            // 
            this.btnAddAttribute.Location = new System.Drawing.Point(186, 239);
            this.btnAddAttribute.Name = "btnAddAttribute";
            this.btnAddAttribute.Size = new System.Drawing.Size(81, 23);
            this.btnAddAttribute.TabIndex = 53;
            this.btnAddAttribute.Text = "Add Attribute";
            this.btnAddAttribute.UseVisualStyleBackColor = true;
            this.btnAddAttribute.Click += new System.EventHandler(this.button3_Click);
            // 
            // nddLevel
            // 
            this.nddLevel.Location = new System.Drawing.Point(272, 85);
            this.nddLevel.Name = "nddLevel";
            this.nddLevel.Size = new System.Drawing.Size(56, 20);
            this.nddLevel.TabIndex = 54;
            // 
            // dgvAttributes
            // 
            this.dgvAttributes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttributes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Attr,
            this.Level});
            this.dgvAttributes.Location = new System.Drawing.Point(353, 56);
            this.dgvAttributes.Name = "dgvAttributes";
            this.dgvAttributes.RowHeadersWidth = 10;
            this.dgvAttributes.Size = new System.Drawing.Size(152, 362);
            this.dgvAttributes.TabIndex = 80;
            this.dgvAttributes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttributes_CellValueChanged);
            // 
            // dgvReqs
            // 
            this.dgvReqs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReqs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvRowAttribute,
            this.dgvCreateMult});
            this.dgvReqs.Location = new System.Drawing.Point(2, 56);
            this.dgvReqs.Name = "dgvReqs";
            this.dgvReqs.Size = new System.Drawing.Size(181, 150);
            this.dgvReqs.TabIndex = 81;
            // 
            // btnAddPreReq
            // 
            this.btnAddPreReq.Location = new System.Drawing.Point(185, 56);
            this.btnAddPreReq.Name = "btnAddPreReq";
            this.btnAddPreReq.Size = new System.Drawing.Size(75, 23);
            this.btnAddPreReq.TabIndex = 82;
            this.btnAddPreReq.Text = "Add PreReq";
            this.btnAddPreReq.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Attribute Exp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Skill Exp";
            // 
            // lblSkillExp
            // 
            this.lblSkillExp.AutoSize = true;
            this.lblSkillExp.Location = new System.Drawing.Point(253, 155);
            this.lblSkillExp.Name = "lblSkillExp";
            this.lblSkillExp.Size = new System.Drawing.Size(13, 13);
            this.lblSkillExp.TabIndex = 85;
            this.lblSkillExp.Text = "0";
            // 
            // lblAttributeExp
            // 
            this.lblAttributeExp.AutoSize = true;
            this.lblAttributeExp.Location = new System.Drawing.Point(253, 135);
            this.lblAttributeExp.Name = "lblAttributeExp";
            this.lblAttributeExp.Size = new System.Drawing.Size(13, 13);
            this.lblAttributeExp.TabIndex = 86;
            this.lblAttributeExp.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "____________";
            // 
            // lblAddAttribute
            // 
            this.lblAddAttribute.AutoSize = true;
            this.lblAddAttribute.Location = new System.Drawing.Point(271, 226);
            this.lblAddAttribute.Name = "lblAddAttribute";
            this.lblAddAttribute.Size = new System.Drawing.Size(77, 13);
            this.lblAddAttribute.TabIndex = 65;
            this.lblAddAttribute.Text = "Attribute Name";
            // 
            // txtAddAttribute
            // 
            this.txtAddAttribute.Location = new System.Drawing.Point(272, 242);
            this.txtAddAttribute.Name = "txtAddAttribute";
            this.txtAddAttribute.Size = new System.Drawing.Size(76, 20);
            this.txtAddAttribute.TabIndex = 64;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(185, 268);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 23);
            this.btnDelete.TabIndex = 88;
            this.btnDelete.Text = "Del Attribute";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // nupCurLevel
            // 
            this.nupCurLevel.Location = new System.Drawing.Point(272, 107);
            this.nupCurLevel.Name = "nupCurLevel";
            this.nupCurLevel.Size = new System.Drawing.Size(56, 20);
            this.nupCurLevel.TabIndex = 90;
            // 
            // lblCurLevel
            // 
            this.lblCurLevel.AutoSize = true;
            this.lblCurLevel.Location = new System.Drawing.Point(185, 109);
            this.lblCurLevel.Name = "lblCurLevel";
            this.lblCurLevel.Size = new System.Drawing.Size(70, 13);
            this.lblCurLevel.TabIndex = 89;
            this.lblCurLevel.Text = "Current Level";
            // 
            // Attr
            // 
            this.Attr.FillWeight = 35F;
            this.Attr.Frozen = true;
            this.Attr.HeaderText = "Attr";
            this.Attr.Name = "Attr";
            this.Attr.ReadOnly = true;
            this.Attr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Attr.Width = 29;
            // 
            // Level
            // 
            this.Level.FillWeight = 35F;
            this.Level.HeaderText = "LVL";
            this.Level.Name = "Level";
            this.Level.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Level.Width = 32;
            // 
            // dgvRowAttribute
            // 
            this.dgvRowAttribute.HeaderText = "Attribute Req";
            this.dgvRowAttribute.Name = "dgvRowAttribute";
            this.dgvRowAttribute.ReadOnly = true;
            this.dgvRowAttribute.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRowAttribute.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvCreateMult
            // 
            this.dgvCreateMult.HeaderText = "Mult";
            this.dgvCreateMult.Name = "dgvCreateMult";
            this.dgvCreateMult.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvCreateMult.Width = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 446);
            this.Controls.Add(this.nupCurLevel);
            this.Controls.Add(this.lblCurLevel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAttributeExp);
            this.Controls.Add(this.lblSkillExp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddPreReq);
            this.Controls.Add(this.dgvReqs);
            this.Controls.Add(this.dgvAttributes);
            this.Controls.Add(this.lblAddAttribute);
            this.Controls.Add(this.txtAddAttribute);
            this.Controls.Add(this.nddLevel);
            this.Controls.Add(this.btnAddAttribute);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblTotalExpCost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nddLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttributes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReqs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCurLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalExpCost;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSave;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddAttribute;
        private System.Windows.Forms.NumericUpDown nddLevel;
        private System.Windows.Forms.DataGridView dgvAttributes;
        private System.Windows.Forms.DataGridView dgvReqs;
        private System.Windows.Forms.Button btnAddPreReq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSkillExp;
        private System.Windows.Forms.Label lblAttributeExp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAddAttribute;
        private System.Windows.Forms.TextBox txtAddAttribute;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.NumericUpDown nupCurLevel;
        private System.Windows.Forms.Label lblCurLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRowAttribute;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCreateMult;
    }
}

