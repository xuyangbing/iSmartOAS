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
    public partial class FrmDepartmentEdit : Form
    {
        public DisplayUpdate ShowUpdate;
        DepartmentService objDepartmentService = new DepartmentService();

        public FrmDepartmentEdit()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.ShowUpdate();
        }

        private void GetDepartmentInfoByID(int id)
        {
            List<Department> list = objDepartmentService.GetDepartmentByID(id.ToString());

            if (0 < list.Count)
            {
                txtDepartmentName.Text = list[0].DepartmentName;
                txtDepartmentPhone.Text = list[0].Telephone;
                txtDepartmentFax.Text = list[0].FaxNumber;
                rtbDepartmentDescribe.Text = list[0].Describe;
            }
        }

        private void AddDepartmentInfo()
        {
            Department department = new Department()
            {
                DepartmentName = this.txtDepartmentName.Text.Trim(),
                Telephone = this.txtDepartmentPhone.Text.Trim(),
                FaxNumber = this.txtDepartmentFax.Text.Trim(),
                Describe = this.rtbDepartmentDescribe.Text
            };

            objDepartmentService.InsertDepartmentInfo(department);
        }

        private void UpdateDepartmentInfo()
        {
            Department department = new Department()
            {
                DepartmentName = this.txtDepartmentName.Text.Trim(),
                Telephone = this.txtDepartmentPhone.Text.Trim(),
                FaxNumber = this.txtDepartmentFax.Text.Trim(),
                Describe = this.rtbDepartmentDescribe.Text,
                DepartmentID = Convert.ToInt32(this.Tag)
            };

            objDepartmentService.UpdateDepartmentInfo(department);
        }

        private void btnDepartmentSave_Click(object sender, EventArgs e)
        {
            if (0 == Convert.ToInt32(this.Tag))
            {
                AddDepartmentInfo();
            }
            else
            {
                UpdateDepartmentInfo();
            }


            this.Close();
            this.ShowUpdate();
        }

        private void FrmDepartmentEdit_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.Tag);
            
            if (0 == id)
            {

            }
            else
            {
                GetDepartmentInfoByID(id);
            }
        }
    }

    public delegate void DisplayUpdate();
}
