using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using Models;

namespace iSmartOASPro
{
    public partial class FrmGoOutState : Form
    {
        internal GoOutStateService objGoOutStateService = new GoOutStateService();
        
        public FrmGoOutState()
        {
            InitializeComponent();
        } 

        private void FrmGoOutState_Load(object sender, EventArgs e)
        {
            FrmInitialization();
        }

        public void FrmInitialization()
        {
            List<GoOutState> list = objGoOutStateService.GetGoOutStateInfo(null, GoOutStateGetDataMode.GET_DATA_MODE_ALL);

            cboxGoOutStateName.DataSource = list;
            cboxGoOutStateName.DisplayMember = "GoOutStateName";
            cboxGoOutStateName.ValueMember = "GoOutStateID";

            this.DataGridViewShow.DataSource = list;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.DataGridViewShow.DataSource = objGoOutStateService.GetGoOutStateInfo
                (
                    this.cboxGoOutStateName.Text.ToString().Trim(), 
                    GoOutStateGetDataMode.GET_DATA_MODE_BY_NAME
                );
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (0 == DataGridViewShow.RowCount || null == DataGridViewShow.CurrentRow)
            {
                MessageBox.Show("请选择需要删除的流程", "提示");
                return;
            }

            DialogResult result = MessageBox.Show("确认要删除吗?", "提示", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                return;
            }

            objGoOutStateService.UpdateGoOutStateInfo
                (
                    null, 
                    DataGridViewShow.CurrentRow.Cells[0].Value.ToString(), 
                    GoOutStateUpdateMode.MODE_DELETE
                );
            FrmInitialization();
        }

        private void btnGoOutStateUpdate_Click(object sender, EventArgs e)
        {
            object id = DataGridViewShow.CurrentRow.Cells[0].Value;
            GoOutStateEdit objGoOutStateEdit = new GoOutStateEdit();
            objGoOutStateEdit.ShowUpdate = new DisplayUpdate(this.FrmInitialization);
            objGoOutStateEdit.Tag = id;
            objGoOutStateEdit.ShowDialog();

            
        }

        private void btnGoOutStateAdd_Click(object sender, EventArgs e)
        {
            GoOutStateEdit objGoOutStateEdit = new GoOutStateEdit();
            objGoOutStateEdit.Tag = 0;
            objGoOutStateEdit.ShowUpdate = new DisplayUpdate(this.FrmInitialization);
            objGoOutStateEdit.ShowDialog();
        }
    }
}
