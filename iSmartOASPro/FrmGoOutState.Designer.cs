namespace iSmartOASPro
{
    partial class FrmGoOutState
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGoOutState));
            this.DataGridViewShow = new System.Windows.Forms.DataGridView();
            this.GoOutStateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoOutStateSeqNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoOutStateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoOutStateDescribe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboxGoOutStateName = new System.Windows.Forms.ComboBox();
            this.btnGoOutStateAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGoOutStateUpdate = new System.Windows.Forms.Button();
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
            this.GoOutStateID,
            this.GoOutStateSeqNumber,
            this.GoOutStateName,
            this.GoOutStateDescribe});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewShow.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewShow.Location = new System.Drawing.Point(58, 177);
            this.DataGridViewShow.Name = "DataGridViewShow";
            this.DataGridViewShow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGridViewShow.RowTemplate.Height = 27;
            this.DataGridViewShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewShow.Size = new System.Drawing.Size(1010, 475);
            this.DataGridViewShow.TabIndex = 28;
            // 
            // GoOutStateID
            // 
            this.GoOutStateID.DataPropertyName = "GoOutStateID";
            this.GoOutStateID.HeaderText = "序号";
            this.GoOutStateID.Name = "GoOutStateID";
            // 
            // GoOutStateSeqNumber
            // 
            this.GoOutStateSeqNumber.DataPropertyName = "GoOutStateSeqNumber";
            this.GoOutStateSeqNumber.HeaderText = "流程编号";
            this.GoOutStateSeqNumber.Name = "GoOutStateSeqNumber";
            // 
            // GoOutStateName
            // 
            this.GoOutStateName.DataPropertyName = "GoOutStateName";
            this.GoOutStateName.HeaderText = "流程名称";
            this.GoOutStateName.Name = "GoOutStateName";
            this.GoOutStateName.Width = 200;
            // 
            // GoOutStateDescribe
            // 
            this.GoOutStateDescribe.DataPropertyName = "GoOutStateDescribe";
            this.GoOutStateDescribe.HeaderText = "流程描述";
            this.GoOutStateDescribe.Name = "GoOutStateDescribe";
            this.GoOutStateDescribe.Width = 315;
            // 
            // cboxGoOutStateName
            // 
            this.cboxGoOutStateName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxGoOutStateName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGoOutStateName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboxGoOutStateName.FormattingEnabled = true;
            this.cboxGoOutStateName.Location = new System.Drawing.Point(137, 29);
            this.cboxGoOutStateName.Name = "cboxGoOutStateName";
            this.cboxGoOutStateName.Size = new System.Drawing.Size(231, 23);
            this.cboxGoOutStateName.TabIndex = 27;
            // 
            // btnGoOutStateAdd
            // 
            this.btnGoOutStateAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnGoOutStateAdd.Image")));
            this.btnGoOutStateAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoOutStateAdd.Location = new System.Drawing.Point(443, 100);
            this.btnGoOutStateAdd.Name = "btnGoOutStateAdd";
            this.btnGoOutStateAdd.Size = new System.Drawing.Size(130, 40);
            this.btnGoOutStateAdd.TabIndex = 26;
            this.btnGoOutStateAdd.Text = "新增流程";
            this.btnGoOutStateAdd.UseVisualStyleBackColor = true;
            this.btnGoOutStateAdd.Click += new System.EventHandler(this.btnGoOutStateAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(640, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 40);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "删除流程";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGoOutStateUpdate
            // 
            this.btnGoOutStateUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnGoOutStateUpdate.Image")));
            this.btnGoOutStateUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoOutStateUpdate.Location = new System.Drawing.Point(255, 100);
            this.btnGoOutStateUpdate.Name = "btnGoOutStateUpdate";
            this.btnGoOutStateUpdate.Size = new System.Drawing.Size(130, 40);
            this.btnGoOutStateUpdate.TabIndex = 24;
            this.btnGoOutStateUpdate.Text = "修改流程";
            this.btnGoOutStateUpdate.UseVisualStyleBackColor = true;
            this.btnGoOutStateUpdate.Click += new System.EventHandler(this.btnGoOutStateUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(58, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 40);
            this.btnSearch.TabIndex = 23;
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
            this.label2.TabIndex = 22;
            this.label2.Text = "流程名称:";
            // 
            // FrmGoOutState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1126, 708);
            this.Controls.Add(this.DataGridViewShow);
            this.Controls.Add(this.cboxGoOutStateName);
            this.Controls.Add(this.btnGoOutStateAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnGoOutStateUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGoOutState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGoOutState";
            this.Load += new System.EventHandler(this.FrmGoOutState_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewShow;
        private System.Windows.Forms.ComboBox cboxGoOutStateName;
        private System.Windows.Forms.Button btnGoOutStateAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGoOutStateUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoOutStateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoOutStateSeqNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoOutStateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoOutStateDescribe;
    }
}