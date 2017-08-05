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
    public partial class FrmTravelState : Form
    {
        private TravelStateService objTravelStateService = new TravelStateService();
        public FrmTravelState()
        {
            InitializeComponent();
        }

        public void FrmInitialization()
        {
            List<TravelState> list = objTravelStateService.GetTravelStateInfo(null, TravelStateGetDataMode.GET_DATA_MODE_ALL);

            cboxTravelStateName.DataSource = list;
            cboxTravelStateName.DisplayMember = "TravelStateName";
            cboxTravelStateName.ValueMember = "TravelStateID";

            this.DataGridViewShow.DataSource = list;
        }

        private void FrmTravelState_Load(object sender, EventArgs e)
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

            objTravelStateService.UpdateTravelStateInfo
                (
                    null, 
                    DataGridViewShow.CurrentRow.Cells[0].Value.ToString(), 
                    TravelStateUpdateDataMode.MODE_DELETE
                );
            FrmInitialization();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataGridViewShow.DataSource = objTravelStateService.GetTravelStateInfo
                (
                    cboxTravelStateName.Text.ToString().Trim(), 
                    TravelStateGetDataMode.GET_DATA_MODE_BY_NAME
                );
        }

        private void btnTravelUpdate_Click(object sender, EventArgs e)
        {
            object id = DataGridViewShow.CurrentRow.Cells[0].Value;
            FrmTravelStateEdit objTravelStateEdit = new FrmTravelStateEdit();
            objTravelStateEdit.ShowUpdate = new DisplayUpdate(this.FrmInitialization);
            objTravelStateEdit.Tag = id;
            objTravelStateEdit.ShowDialog();
        }

        private void btnTravelStateAdd_Click(object sender, EventArgs e)
        {
            FrmTravelStateEdit objTravelStateEdit = new FrmTravelStateEdit();
            objTravelStateEdit.ShowUpdate = new DisplayUpdate(this.FrmInitialization);
            objTravelStateEdit.Tag = 0;
            objTravelStateEdit.ShowDialog();
        }
    }
}
