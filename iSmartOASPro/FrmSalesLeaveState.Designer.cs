namespace iSmartOASPro
{
    partial class FrmSalesLeaveState
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalesLeaveState));
            this.DataGridViewShow = new System.Windows.Forms.DataGridView();
            this.SalesLeaveStateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesLeaveStateSeqNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesLeaveStateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesLeaveStateDescribe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboxSalesLeaveStateName = new System.Windows.Forms.ComboBox();
            this.btnSalesLeaveStateAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSalesLeaveStateUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewShow)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewShow
            // 
            this.DataGridViewShow.AllowUserToAddRows = false;
            this.DataGridViewShow.AllowUserToDeleteRows = false;
            this.DataGridViewShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewShow.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewShow.ColumnHeadersHeight = 30;
            this.DataGridViewShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesLeaveStateID,
            this.SalesLeaveStateSeqNumber,
            this.SalesLeaveStateName,
            this.SalesLeaveStateDescribe});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewShow.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewShow.Location = new System.Drawing.Point(54, 177);
            this.DataGridViewShow.Name = "DataGridViewShow";
            this.DataGridViewShow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGridViewShow.RowTemplate.Height = 27;
            this.DataGridViewShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewShow.Size = new System.Drawing.Size(1010, 475);
            this.DataGridViewShow.TabIndex = 35;
            // 
            // SalesLeaveStateID
            // 
            this.SalesLeaveStateID.DataPropertyName = "SalesLeaveStateID";
            this.SalesLeaveStateID.HeaderText = "序号";
            this.SalesLeaveStateID.Name = "SalesLeaveStateID";
            // 
            // SalesLeaveStateSeqNumber
            // 
            this.SalesLeaveStateSeqNumber.DataPropertyName = "SalesLeaveStateSeqNumber";
            this.SalesLeaveStateSeqNumber.HeaderText = "流程编号";
            this.SalesLeaveStateSeqNumber.Name = "SalesLeaveStateSeqNumber";
            // 
            // SalesLeaveStateName
            // 
            this.SalesLeaveStateName.DataPropertyName = "SalesLeaveStateName";
            this.SalesLeaveStateName.HeaderText = "流程名称";
            this.SalesLeaveStateName.Name = "SalesLeaveStateName";
            this.SalesLeaveStateName.Width = 200;
            // 
            // SalesLeaveStateDescribe
            // 
            this.SalesLeaveStateDescribe.DataPropertyName = "SalesLeaveStateDescribe";
            this.SalesLeaveStateDescribe.HeaderText = "流程描述";
            this.SalesLeaveStateDescribe.Name = "SalesLeaveStateDescribe";
            this.SalesLeaveStateDescribe.Width = 315;
            // 
            // cboxSalesLeaveStateName
            // 
            this.cboxSalesLeaveStateName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxSalesLeaveStateName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSalesLeaveStateName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboxSalesLeaveStateName.FormattingEnabled = true;
            this.cboxSalesLeaveStateName.Location = new System.Drawing.Point(135, 29);
            this.cboxSalesLeaveStateName.Name = "cboxSalesLeaveStateName";
            this.cboxSalesLeaveStateName.Size = new System.Drawing.Size(231, 23);
            this.cboxSalesLeaveStateName.TabIndex = 34;
            // 
            // btnSalesLeaveStateAdd
            // 
            this.btnSalesLeaveStateAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnSalesLeaveStateAdd.Image")));
            this.btnSalesLeaveStateAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesLeaveStateAdd.Location = new System.Drawing.Point(445, 100);
            this.btnSalesLeaveStateAdd.Name = "btnSalesLeaveStateAdd";
            this.btnSalesLeaveStateAdd.Size = new System.Drawing.Size(130, 40);
            this.btnSalesLeaveStateAdd.TabIndex = 33;
            this.btnSalesLeaveStateAdd.Text = "新增流程";
            this.btnSalesLeaveStateAdd.UseVisualStyleBackColor = true;
            this.btnSalesLeaveStateAdd.Click += new System.EventHandler(this.btnSalesLeaveStateAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(642, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 40);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "删除流程";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSalesLeaveStateUpdate
            // 
            this.btnSalesLeaveStateUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnSalesLeaveStateUpdate.Image")));
            this.btnSalesLeaveStateUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesLeaveStateUpdate.Location = new System.Drawing.Point(257, 100);
            this.btnSalesLeaveStateUpdate.Name = "btnSalesLeaveStateUpdate";
            this.btnSalesLeaveStateUpdate.Size = new System.Drawing.Size(130, 40);
            this.btnSalesLeaveStateUpdate.TabIndex = 31;
            this.btnSalesLeaveStateUpdate.Text = "修改流程";
            this.btnSalesLeaveStateUpdate.UseVisualStyleBackColor = true;
            this.btnSalesLeaveStateUpdate.Click += new System.EventHandler(this.btnSalesLeaveStateUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(54, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 40);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "信息查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(58, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "流程名称:";
            // 
            // FrmSalesLeaveState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1126, 768);
            this.Controls.Add(this.DataGridViewShow);
            this.Controls.Add(this.cboxSalesLeaveStateName);
            this.Controls.Add(this.btnSalesLeaveStateAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSalesLeaveStateUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSalesLeaveState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSalesLeaveState";
            this.Load += new System.EventHandler(this.FrmSalesLeaveState_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewShow;
        private System.Windows.Forms.ComboBox cboxSalesLeaveStateName;
        private System.Windows.Forms.Button btnSalesLeaveStateAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSalesLeaveStateUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesLeaveStateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesLeaveStateSeqNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesLeaveStateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesLeaveStateDescribe;
    }
}