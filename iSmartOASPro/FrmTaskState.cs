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
    public partial class FrmTaskState : Form
    {
        private TaskStateService objTaskStateService = new TaskStateService();

        public FrmTaskState()
        {
            InitializeComponent();
        }

        public void FrmInitialization()
        {
            List<TaskState> list = objTaskStateService.GetTaskStateInfo(null, TaskStateService.TaskStateGetDataMode.GET_DATA_MODE_ALL);

            cboxTaskStateName.DataSource = list;
            cboxTaskStateName.DisplayMember = "TaskStateName";
            cboxTaskStateName.ValueMember = "TaskStateID";

            this.DataGridViewShow.DataSource = list;
        }

        private void FrmTaskState_Load(object sender, EventArgs e)
        {
            FrmInitialization();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataGridViewShow.DataSource = objTaskStateService.GetTaskStateInfo
                (
                    cboxTaskStateName.Text.ToString().Trim(), 
                    TaskStateService.TaskStateGetDataMode.GET_DATA_MODE_BY_NAME
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

            objTaskStateService.UpdateTaskStateInfo
                (
                    null, 
                    DataGridViewShow.CurrentRow.Cells[0].Value.ToString(), 
                    TaskStateService.TaskStateUpdateDataMode.MODE_DELETE
                );

            FrmInitialization();
        }

        private void btnTaskStateUpdate_Click(object sender, EventArgs e)
        {
            object id = DataGridViewShow.CurrentRow.Cells[0].Value;
            FrmTaskStateEdit objTaskState = new FrmTaskStateEdit();
            objTaskState.Tag = id;
            objTaskState.ShowUpdate = new DisplayUpdate(this.FrmInitialization);
            objTaskState.ShowDialog();
        }

        private void btnTaskStateAdd_Click(object sender, EventArgs e)
        {
            FrmTaskStateEdit objTaskState = new FrmTaskStateEdit();
            objTaskState.Tag = 0;
            objTaskState.ShowUpdate = new DisplayUpdate(this.FrmInitialization);
            objTaskState.ShowDialog();
        }
    }
}
