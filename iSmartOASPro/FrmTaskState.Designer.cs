namespace iSmartOASPro
{
    partial class FrmTaskState
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTaskState));
            this.DataGridViewShow = new System.Windows.Forms.DataGridView();
            this.TaskStateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskStateSeqNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskStateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskStateDescribe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboxTaskStateName = new System.Windows.Forms.ComboBox();
            this.btnTaskStateAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTaskStateUpdate = new System.Windows.Forms.Button();
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
            this.TaskStateID,
            this.TaskStateSeqNumber,
            this.TaskStateName,
            this.TaskStateDescribe});
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
            this.DataGridViewShow.TabIndex = 42;
            // 
            // TaskStateID
            // 
            this.TaskStateID.DataPropertyName = "TaskStateID";
            this.TaskStateID.HeaderText = "序号";
            this.TaskStateID.Name = "TaskStateID";
            // 
            // TaskStateSeqNumber
            // 
            this.TaskStateSeqNumber.DataPropertyName = "TaskStateSeqNumber";
            this.TaskStateSeqNumber.HeaderText = "流程编号";
            this.TaskStateSeqNumber.Name = "TaskStateSeqNumber";
            // 
            // TaskStateName
            // 
            this.TaskStateName.DataPropertyName = "TaskStateName";
            this.TaskStateName.HeaderText = "流程名称";
            this.TaskStateName.Name = "TaskStateName";
            this.TaskStateName.Width = 200;
            // 
            // TaskStateDescribe
            // 
            this.TaskStateDescribe.DataPropertyName = "TaskStateDescribe";
            this.TaskStateDescribe.HeaderText = "流程描述";
            this.TaskStateDescribe.Name = "TaskStateDescribe";
            this.TaskStateDescribe.Width = 315;
            // 
            // cboxTaskStateName
            // 
            this.cboxTaskStateName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxTaskStateName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTaskStateName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboxTaskStateName.FormattingEnabled = true;
            this.cboxTaskStateName.Location = new System.Drawing.Point(135, 29);
            this.cboxTaskStateName.Name = "cboxTaskStateName";
            this.cboxTaskStateName.Size = new System.Drawing.Size(231, 23);
            this.cboxTaskStateName.TabIndex = 41;
            // 
            // btnTaskStateAdd
            // 
            this.btnTaskStateAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnTaskStateAdd.Image")));
            this.btnTaskStateAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaskStateAdd.Location = new System.Drawing.Point(449, 100);
            this.btnTaskStateAdd.Name = "btnTaskStateAdd";
            this.btnTaskStateAdd.Size = new System.Drawing.Size(130, 40);
            this.btnTaskStateAdd.TabIndex = 40;
            this.btnTaskStateAdd.Text = "新增流程";
            this.btnTaskStateAdd.UseVisualStyleBackColor = true;
            this.btnTaskStateAdd.Click += new System.EventHandler(this.btnTaskStateAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(646, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 40);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "删除流程";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTaskStateUpdate
            // 
            this.btnTaskStateUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnTaskStateUpdate.Image")));
            this.btnTaskStateUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaskStateUpdate.Location = new System.Drawing.Point(261, 100);
            this.btnTaskStateUpdate.Name = "btnTaskStateUpdate";
            this.btnTaskStateUpdate.Size = new System.Drawing.Size(130, 40);
            this.btnTaskStateUpdate.TabIndex = 38;
            this.btnTaskStateUpdate.Text = "修改流程";
            this.btnTaskStateUpdate.UseVisualStyleBackColor = true;
            this.btnTaskStateUpdate.Click += new System.EventHandler(this.btnTaskStateUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(54, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 40);
            this.btnSearch.TabIndex = 37;
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
            this.label2.TabIndex = 36;
            this.label2.Text = "流程名称:";
            // 
            // FrmTaskState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1126, 708);
            this.Controls.Add(this.DataGridViewShow);
            this.Controls.Add(this.cboxTaskStateName);
            this.Controls.Add(this.btnTaskStateAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnTaskStateUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTaskState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTaskState";
            this.Load += new System.EventHandler(this.FrmTaskState_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewShow;
        private System.Windows.Forms.ComboBox cboxTaskStateName;
        private System.Windows.Forms.Button btnTaskStateAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnTaskStateUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskStateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskStateSeqNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskStateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskStateDescribe;
    }
}