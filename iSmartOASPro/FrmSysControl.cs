using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iSmartOASPro
{
    public partial class FrmSysControl : Form
    {
        public FrmSysControl()
        {
            InitializeComponent();
        }

        private void FrmSysControl_Load(object sender, EventArgs e)
        {
            this.lblHeaderName.Text = "控制面板";
        }

        private void CloseSubForms()
        {
            foreach (Control item in this.SplitcontainerControl.Panel2.Controls)
            {
                if (item is Form)
                {
                    Form objForm = (Form)item;
                    objForm.Close();
                    this.SplitcontainerControl.Panel2.Controls.Remove(item);
                }
            }
        }

        private void btnDepartMent_Click(object sender, EventArgs e)
        {
            CloseSubForms();
            lblHeaderName.Text = "控制面板 > 部门管理";
            FrmDepartment department = new FrmDepartment();
            department.MdiParent = this;
            department.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            SplitcontainerControl.Panel2.Controls.Add(department);
            department.Dock = DockStyle.Fill;
            department.Show();
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSysControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void btnProcessManagement_Click(object sender, EventArgs e)
        {
            CloseSubForms();
            lblHeaderName.Text = "控制面板 > 请假流程管理";
            FrmDayOff dayOff = new FrmDayOff();
            dayOff.MdiParent = this;
            dayOff.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            SplitcontainerControl.Panel2.Controls.Add(dayOff);
            dayOff.Dock = DockStyle.Fill;
            dayOff.Show();
        }

        private void btnGoOutState_Click(object sender, EventArgs e)
        {
            CloseSubForms();
            lblHeaderName.Text = "控制面板 > 外出流程管理";
            FrmGoOutState goOutState = new FrmGoOutState();
            goOutState.MdiParent = this;
            goOutState.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            SplitcontainerControl.Panel2.Controls.Add(goOutState);
            goOutState.Dock = DockStyle.Fill;
            goOutState.Show();
        }

        private void btnTravelState_Click(object sender, EventArgs e)
        {
            CloseSubForms();
            lblHeaderName.Text = "控制面板 > 出差流程管理";
            FrmTravelState travelState = new FrmTravelState();
            travelState.MdiParent = this;
            travelState.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            SplitcontainerControl.Panel2.Controls.Add(travelState);
            travelState.Dock = DockStyle.Fill;
            travelState.Show();
        }

        private void btnSalesLeaveState_Click(object sender, EventArgs e)
        {
            CloseSubForms();
            lblHeaderName.Text = "控制面板 > 销假流程管理";
            FrmSalesLeaveState salesLeaveState = new FrmSalesLeaveState();
            salesLeaveState.MdiParent = this;
            salesLeaveState.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            SplitcontainerControl.Panel2.Controls.Add(salesLeaveState);
            salesLeaveState.Dock = DockStyle.Fill;
            salesLeaveState.Show();
        }

        private void btnTaskState_Click(object sender, EventArgs e)
        {
            CloseSubForms();
            lblHeaderName.Text = "控制面板 > 任务流程管理";
            FrmTaskState taskState = new FrmTaskState();
            taskState.MdiParent = this;
            taskState.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            SplitcontainerControl.Panel2.Controls.Add(taskState);
            taskState.Dock = DockStyle.Fill;
            taskState.Show();
        }
    }
}
