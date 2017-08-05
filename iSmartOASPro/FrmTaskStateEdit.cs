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
    public partial class FrmTaskStateEdit : Form
    {
        public DisplayUpdate ShowUpdate;
        private TaskStateService objTaskStateService = new TaskStateService();

        public FrmTaskStateEdit()
        {
            InitializeComponent();
        }

        private void GetTaskStateInfoByID(int id)
        {
            List<TaskState> list = objTaskStateService.GetTaskStateInfo(id.ToString(), TaskStateService.TaskStateGetDataMode.GET_DATA_MODE_BY_ID);

            if (0 < list.Count)
            {
                this.txtTaskStateName.Text = list[0].TaskStateName;
                this.txtSequenceNumber.Text = list[0].TaskStateSeqNumber.ToString();
                this.rtbTaskStateDescribe.Text = list[0].TaskStateDescribe;
            }
        }

        private void FrmTaskStateEdit_Load(object sender, EventArgs e)
        {
            if (0 == Convert.ToInt32(this.Tag))
            {
                return;
            }
            else
            {
                GetTaskStateInfoByID(Convert.ToInt32(this.Tag));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.ShowUpdate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TaskState info = new TaskState();

            info.TaskStateName = this.txtTaskStateName.Text.ToString().Trim();
            info.TaskStateSeqNumber = Convert.ToInt32(this.txtSequenceNumber.Text);
            info.TaskStateDescribe = this.rtbTaskStateDescribe.Text.ToString();

            if (0 == Convert.ToInt32(this.Tag))
            {
                objTaskStateService.UpdateTaskStateInfo(info, null, TaskStateService.TaskStateUpdateDataMode.MODE_INSERT);
            }
            else
            {
                info.TaskStateID = Convert.ToInt32(this.Tag);
                objTaskStateService.UpdateTaskStateInfo(info, null, TaskStateService.TaskStateUpdateDataMode.MODE_UPDATE);
            }

            this.Close();
            this.ShowUpdate();
        }
    }
}
