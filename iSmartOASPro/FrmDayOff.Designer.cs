namespace iSmartOASPro
{
    partial class FrmDayOff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDayOff));
            this.DataGridViewShow = new System.Windows.Forms.DataGridView();
            this.DayOffStateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SequenceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayOffStateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayOffStateDescribe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboxDayOffStateName = new System.Windows.Forms.ComboBox();
            this.btnDayOffStateAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDayOffStateUpdate = new System.Windows.Forms.Button();
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
            this.DayOffStateID,
            this.SequenceNumber,
            this.DayOffStateName,
            this.DayOffStateDescribe});
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
            this.DataGridViewShow.TabIndex = 21;
            // 
            // DayOffStateID
            // 
            this.DayOffStateID.DataPropertyName = "DayOffStateID";
            this.DayOffStateID.HeaderText = "序号";
            this.DayOffStateID.Name = "DayOffStateID";
            // 
            // SequenceNumber
            // 
            this.SequenceNumber.DataPropertyName = "SequenceNumber";
            this.SequenceNumber.HeaderText = "流程编号";
            this.SequenceNumber.Name = "SequenceNumber";
            // 
            // DayOffStateName
            // 
            this.DayOffStateName.DataPropertyName = "DayOffStateName";
            this.DayOffStateName.HeaderText = "流程名称";
            this.DayOffStateName.Name = "DayOffStateName";
            this.DayOffStateName.Width = 200;
            // 
            // DayOffStateDescribe
            // 
            this.DayOffStateDescribe.DataPropertyName = "DayOffStateDescribe";
            this.DayOffStateDescribe.HeaderText = "流程描述";
            this.DayOffStateDescribe.Name = "DayOffStateDescribe";
            this.DayOffStateDescribe.Width = 315;
            // 
            // cboxDayOffStateName
            // 
            this.cboxDayOffStateName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxDayOffStateName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDayOffStateName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboxDayOffStateName.FormattingEnabled = true;
            this.cboxDayOffStateName.Location = new System.Drawing.Point(133, 29);
            this.cboxDayOffStateName.Name = "cboxDayOffStateName";
            this.cboxDayOffStateName.Size = new System.Drawing.Size(231, 23);
            this.cboxDayOffStateName.TabIndex = 20;
            // 
            // btnDayOffStateAdd
            // 
            this.btnDayOffStateAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnDayOffStateAdd.Image")));
            this.btnDayOffStateAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDayOffStateAdd.Location = new System.Drawing.Point(439, 100);
            this.btnDayOffStateAdd.Name = "btnDayOffStateAdd";
            this.btnDayOffStateAdd.Size = new System.Drawing.Size(130, 40);
            this.btnDayOffStateAdd.TabIndex = 19;
            this.btnDayOffStateAdd.Text = "新增流程";
            this.btnDayOffStateAdd.UseVisualStyleBackColor = true;
            this.btnDayOffStateAdd.Click += new System.EventHandler(this.btnDayOffStateAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(636, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 40);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "删除流程";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDayOffStateUpdate
            // 
            this.btnDayOffStateUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnDayOffStateUpdate.Image")));
            this.btnDayOffStateUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDayOffStateUpdate.Location = new System.Drawing.Point(251, 100);
            this.btnDayOffStateUpdate.Name = "btnDayOffStateUpdate";
            this.btnDayOffStateUpdate.Size = new System.Drawing.Size(130, 40);
            this.btnDayOffStateUpdate.TabIndex = 17;
            this.btnDayOffStateUpdate.Text = "修改流程";
            this.btnDayOffStateUpdate.UseVisualStyleBackColor = true;
            this.btnDayOffStateUpdate.Click += new System.EventHandler(this.btnDayOffStateUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(54, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 40);
            this.btnSearch.TabIndex = 16;
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
            this.label2.TabIndex = 15;
            this.label2.Text = "流程名称:";
            // 
            // FrmDayOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1126, 708);
            this.Controls.Add(this.DataGridViewShow);
            this.Controls.Add(this.cboxDayOffStateName);
            this.Controls.Add(this.btnDayOffStateAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDayOffStateUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDayOff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDayOff";
            this.Load += new System.EventHandler(this.FrmDayOff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewShow;
        private System.Windows.Forms.ComboBox cboxDayOffStateName;
        private System.Windows.Forms.Button btnDayOffStateAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDayOffStateUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayOffStateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SequenceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayOffStateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayOffStateDescribe;
    }
}