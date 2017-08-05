using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;
using DAL;

namespace iSmartOASPro
{
    public partial class FrmSalesLeaveState : Form
    {
        private SalesLeaveStateService objSalesLeaveStateService = new SalesLeaveStateService();

        public FrmSalesLeaveState()
        {
            InitializeComponent();
        }

        public void FrmInitialization()
        {
            List<SalesLeaveState> list = objSalesLeaveStateService.GetSalesLeaveStateInfo
                (
                    null, 
                    SalesLeaveStateGetDataMode.GET_DATA_MODE_ALL
                );
            cboxSalesLeaveStateName.DataSource = list;
            cboxSalesLeaveStateName.DisplayMember = "SalesLeaveStateName";
            cboxSalesLeaveStateName.ValueMember = "SalesLeaveStateID";

            this.DataGridViewShow.DataSource = list;
        }

        private void FrmSalesLeaveState_Load(object sender, EventArgs e)
        {
            FrmInitialization();
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

            objSalesLeaveStateService.UpdateSalesLeaveStateInfo
                (
                    null, 
                    this.DataGridViewShow.CurrentRow.Cells[0].Value.ToString(), 
                    SalesLeaveStateUpdateDataMode.MODE_DELETE
                );

            FrmInitialization();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataGridViewShow.DataSource = objSalesLeaveStateService.GetSalesLeaveStateInfo
                (
                    cboxSalesLeaveStateName.Text.ToString().Trim(), 
                    SalesLeaveStateGetDataMode.GET_DATA_MODE_BY_NAME
                );
        }

        private void btnSalesLeaveStateUpdate_Click(object sender, EventArgs e)
        {
            object id = DataGridViewShow.CurrentRow.Cells[0].Value;
            FrmSalesLeaveStateEdit objSalesLeaveStateEdit = new FrmSalesLeaveStateEdit();
            objSalesLeaveStateEdit.Tag = id;
            objSalesLeaveStateEdit.ShowUpdate = new DisplayUpdate(this.FrmInitialization);
            objSalesLeaveStateEdit.ShowDialog();
        }

        private void btnSalesLeaveStateAdd_Click(object sender, EventArgs e)
        {
            FrmSalesLeaveStateEdit objSalesLeaveStateEdit = new FrmSalesLeaveStateEdit();
            objSalesLeaveStateEdit.Tag = 0;
            objSalesLeaveStateEdit.ShowUpdate = new DisplayUpdate(this.FrmInitialization);
            objSalesLeaveStateEdit.ShowDialog();
        }
    }
}
