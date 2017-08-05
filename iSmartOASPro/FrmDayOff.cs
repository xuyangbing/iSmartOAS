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
    /// <summary>
    /// 请假流程管理
    /// </summary>
    public partial class FrmDayOff : Form
    {
	//xxxxxxx
        internal DayOffStateService objDayOffStateService = new DayOffStateService();
        
        public FrmDayOff()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
=======
        public void showMyself()
        {
	    Console.WriteLine("TEST");
            return;
        }

>>>>>>> 1d5eca4792e59992132eecd208c29d0138330be6
        private void FrmDayOff_Load(object sender, EventArgs e)
        {
            FrmInitialization();
        }

        public void FrmInitialization()
        {
            List<DayOffState> list = objDayOffStateService.GetDayOffStateInfo(null, DayOffStateGetDataMode.GET_DATA_ALL);

            cboxDayOffStateName.DataSource = list;
            cboxDayOffStateName.DisplayMember = "DayOffStateName";
            cboxDayOffStateName.ValueMember = "DayOffStateID";

            this.DataGridViewShow.DataSource = list;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.DataGridViewShow.DataSource = objDayOffStateService.GetDayOffStateInfo
                (
                    cboxDayOffStateName.Text.ToString().Trim(), 
                    DayOffStateGetDataMode.GET_DATA_BY_NAME
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
            objDayOffStateService.UpdateDayOffStateInfo
                (
                    null,
                    DataGridViewShow.CurrentRow.Cells[0].Value.ToString(),
                    DayOffStateUpdateMode.MODE_DELETE
                );

            FrmInitialization();
        }

        private void btnDayOffStateUpdate_Click(object sender, EventArgs e)
        {
            object id = DataGridViewShow.CurrentRow.Cells[0].Value;
            FrmDayOffStateEdit objDayOffState = new FrmDayOffStateEdit();
            objDayOffState.Tag = id;
            objDayOffState.ShowUpdate = new DisplayUpdate(this.FrmInitialization);
            objDayOffState.ShowDialog();
        }

        private void btnDayOffStateAdd_Click(object sender, EventArgs e)
        {
            FrmDayOffStateEdit objDayOffState = new FrmDayOffStateEdit();
            objDayOffState.Tag = 0;
            objDayOffState.ShowUpdate = new DisplayUpdate(this.FrmInitialization);
            objDayOffState.ShowDialog();
        }

    }
}
