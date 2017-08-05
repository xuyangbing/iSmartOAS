namespace iSmartOASPro
{
    partial class FrmTravelState
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTravelState));
            this.DataGridViewShow = new System.Windows.Forms.DataGridView();
            this.TravelStateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelStateSeqNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelStateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelStateDescribe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboxTravelStateName = new System.Windows.Forms.ComboBox();
            this.btnTravelStateAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTravelUpdate = new System.Windows.Forms.Button();
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
            this.TravelStateID,
            this.TravelStateSeqNumber,
            this.TravelStateName,
            this.TravelStateDescribe});
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
            // TravelStateID
            // 
            this.TravelStateID.DataPropertyName = "TravelStateID";
            this.TravelStateID.HeaderText = "序号";
            this.TravelStateID.Name = "TravelStateID";
            // 
            // TravelStateSeqNumber
            // 
            this.TravelStateSeqNumber.DataPropertyName = "TravelStateSeqNumber";
            this.TravelStateSeqNumber.HeaderText = "流程编号";
            this.TravelStateSeqNumber.Name = "TravelStateSeqNumber";
            // 
            // TravelStateName
            // 
            this.TravelStateName.DataPropertyName = "TravelStateName";
            this.TravelStateName.HeaderText = "流程名称";
            this.TravelStateName.Name = "TravelStateName";
            this.TravelStateName.Width = 200;
            // 
            // TravelStateDescribe
            // 
            this.TravelStateDescribe.DataPropertyName = "TravelStateDescribe";
            this.TravelStateDescribe.HeaderText = "流程描述";
            this.TravelStateDescribe.Name = "TravelStateDescribe";
            this.TravelStateDescribe.Width = 315;
            // 
            // cboxTravelStateName
            // 
            this.cboxTravelStateName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxTravelStateName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTravelStateName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboxTravelStateName.FormattingEnabled = true;
            this.cboxTravelStateName.Location = new System.Drawing.Point(133, 29);
            this.cboxTravelStateName.Name = "cboxTravelStateName";
            this.cboxTravelStateName.Size = new System.Drawing.Size(231, 23);
            this.cboxTravelStateName.TabIndex = 27;
            // 
            // btnTravelStateAdd
            // 
            this.btnTravelStateAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnTravelStateAdd.Image")));
            this.btnTravelStateAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTravelStateAdd.Location = new System.Drawing.Point(443, 100);
            this.btnTravelStateAdd.Name = "btnTravelStateAdd";
            this.btnTravelStateAdd.Size = new System.Drawing.Size(130, 40);
            this.btnTravelStateAdd.TabIndex = 26;
            this.btnTravelStateAdd.Text = "新增流程";
            this.btnTravelStateAdd.UseVisualStyleBackColor = true;
            this.btnTravelStateAdd.Click += new System.EventHandler(this.btnTravelStateAdd_Click);
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
            // btnTravelUpdate
            // 
            this.btnTravelUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnTravelUpdate.Image")));
            this.btnTravelUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTravelUpdate.Location = new System.Drawing.Point(255, 100);
            this.btnTravelUpdate.Name = "btnTravelUpdate";
            this.btnTravelUpdate.Size = new System.Drawing.Size(130, 40);
            this.btnTravelUpdate.TabIndex = 24;
            this.btnTravelUpdate.Text = "修改流程";
            this.btnTravelUpdate.UseVisualStyleBackColor = true;
            this.btnTravelUpdate.Click += new System.EventHandler(this.btnTravelUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(54, 100);
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
            // FrmTravelState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1126, 708);
            this.Controls.Add(this.DataGridViewShow);
            this.Controls.Add(this.cboxTravelStateName);
            this.Controls.Add(this.btnTravelStateAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnTravelUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTravelState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTravelState";
            this.Load += new System.EventHandler(this.FrmTravelState_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewShow;
        private System.Windows.Forms.ComboBox cboxTravelStateName;
        private System.Windows.Forms.Button btnTravelStateAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnTravelUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelStateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelStateSeqNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelStateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelStateDescribe;
    }
}