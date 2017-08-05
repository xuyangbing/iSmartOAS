namespace iSmartOASPro
{
    partial class FrmDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDepartmentUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDepartmentAdd = new System.Windows.Forms.Button();
            this.cboxDepartmentName = new System.Windows.Forms.ComboBox();
            this.DataGridViwShow = new System.Windows.Forms.DataGridView();
            this.DepartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaxNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Describe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViwShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(53, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "部门名称:";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(54, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 40);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "信息查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDepartmentUpdate
            // 
            this.btnDepartmentUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnDepartmentUpdate.Image")));
            this.btnDepartmentUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartmentUpdate.Location = new System.Drawing.Point(246, 100);
            this.btnDepartmentUpdate.Name = "btnDepartmentUpdate";
            this.btnDepartmentUpdate.Size = new System.Drawing.Size(130, 40);
            this.btnDepartmentUpdate.TabIndex = 10;
            this.btnDepartmentUpdate.Text = "修改部门";
            this.btnDepartmentUpdate.UseVisualStyleBackColor = true;
            this.btnDepartmentUpdate.Click += new System.EventHandler(this.btnDepartmentUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(631, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 40);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "删除部门";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDepartmentAdd
            // 
            this.btnDepartmentAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnDepartmentAdd.Image")));
            this.btnDepartmentAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartmentAdd.Location = new System.Drawing.Point(434, 100);
            this.btnDepartmentAdd.Name = "btnDepartmentAdd";
            this.btnDepartmentAdd.Size = new System.Drawing.Size(130, 40);
            this.btnDepartmentAdd.TabIndex = 12;
            this.btnDepartmentAdd.Text = "新增部门";
            this.btnDepartmentAdd.UseVisualStyleBackColor = true;
            this.btnDepartmentAdd.Click += new System.EventHandler(this.btnDepartmentAdd_Click);
            // 
            // cboxDepartmentName
            // 
            this.cboxDepartmentName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxDepartmentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDepartmentName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboxDepartmentName.FormattingEnabled = true;
            this.cboxDepartmentName.Location = new System.Drawing.Point(133, 29);
            this.cboxDepartmentName.Name = "cboxDepartmentName";
            this.cboxDepartmentName.Size = new System.Drawing.Size(231, 23);
            this.cboxDepartmentName.TabIndex = 13;
            // 
            // DataGridViwShow
            // 
            this.DataGridViwShow.AllowUserToAddRows = false;
            this.DataGridViwShow.AllowUserToDeleteRows = false;
            this.DataGridViwShow.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViwShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViwShow.ColumnHeadersHeight = 30;
            this.DataGridViwShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViwShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartmentID,
            this.DepartmentName,
            this.Telephone,
            this.FaxNumber,
            this.Describe});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViwShow.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViwShow.Location = new System.Drawing.Point(54, 177);
            this.DataGridViwShow.Name = "DataGridViwShow";
            this.DataGridViwShow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGridViwShow.RowTemplate.Height = 27;
            this.DataGridViwShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViwShow.Size = new System.Drawing.Size(1010, 475);
            this.DataGridViwShow.TabIndex = 14;
            // 
            // DepartmentID
            // 
            this.DepartmentID.DataPropertyName = "DepartmentID";
            this.DepartmentID.HeaderText = "部门编号";
            this.DepartmentID.Name = "DepartmentID";
            // 
            // DepartmentName
            // 
            this.DepartmentName.DataPropertyName = "DepartmentName";
            this.DepartmentName.HeaderText = "部门名称";
            this.DepartmentName.Name = "DepartmentName";
            // 
            // Telephone
            // 
            this.Telephone.DataPropertyName = "Telephone";
            this.Telephone.HeaderText = "部门电话";
            this.Telephone.Name = "Telephone";
            // 
            // FaxNumber
            // 
            this.FaxNumber.DataPropertyName = "FaxNumber";
            this.FaxNumber.HeaderText = "部门传真";
            this.FaxNumber.Name = "FaxNumber";
            // 
            // Describe
            // 
            this.Describe.DataPropertyName = "Describe";
            this.Describe.HeaderText = "部门职责";
            this.Describe.Name = "Describe";
            this.Describe.Width = 315;
            // 
            // FrmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1126, 708);
            this.Controls.Add(this.DataGridViwShow);
            this.Controls.Add(this.cboxDepartmentName);
            this.Controls.Add(this.btnDepartmentAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDepartmentUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDepartment";
            this.Load += new System.EventHandler(this.FrmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViwShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDepartmentUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDepartmentAdd;
        private System.Windows.Forms.ComboBox cboxDepartmentName;
        private System.Windows.Forms.DataGridView DataGridViwShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaxNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Describe;
    }
}