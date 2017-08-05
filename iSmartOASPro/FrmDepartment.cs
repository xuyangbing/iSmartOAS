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
    public partial class FrmDepartment : Form
    {
        internal DepartmentService objDepartmentService = new DepartmentService();

        public FrmDepartment()
        {
            InitializeComponent();
        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            FrmInitialization();
        }

        /// <summary>
        /// 窗体加载时绑定数据源接口
        /// </summary>
        public void FrmInitialization()
        {
            List<Department> list = objDepartmentService.GetDepartmentAll();

            this.cboxDepartmentName.DataSource = list;
            this.cboxDepartmentName.DisplayMember = "DepartmentName";
            this.cboxDepartmentName.ValueMember = "DepartmentID";

            this.DataGridViwShow.DataSource = list;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.DataGridViwShow.DataSource = objDepartmentService.GetDepartmentByName(cboxDepartmentName.Text.ToString().Trim());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (0 == DataGridViwShow.RowCount || null == DataGridViwShow.CurrentRow)
            {
                MessageBox.Show("请选择需要删除的部门", "提示");
                return;
            }

            DialogResult result = MessageBox.Show("确认要删除吗?", "提示", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                return;
            }

            string departmentID = DataGridViwShow.CurrentRow.Cells[0].Value.ToString();

            objDepartmentService.DeleteDepartmentByID(departmentID);

            FrmInitialization();
        }

        private void btnDepartmentAdd_Click(object sender, EventArgs e)
        {
            FrmDepartmentEdit departmentEdit = new FrmDepartmentEdit();
            departmentEdit.ShowUpdate += new DisplayUpdate(this.FrmInitialization);
            departmentEdit.Tag = 0;
            departmentEdit.ShowDialog();
        }

        private void btnDepartmentUpdate_Click(object sender, EventArgs e)
        {
            object id = this.DataGridViwShow.CurrentRow.Cells[0].Value;
            FrmDepartmentEdit departmentEdit = new FrmDepartmentEdit();
            departmentEdit.ShowUpdate += new DisplayUpdate(this.FrmInitialization);
            departmentEdit.Tag = id;
            departmentEdit.ShowDialog();
        }
    }
}
