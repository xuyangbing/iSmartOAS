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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("MainFrm");
            this.lblSysInfo.BackColor = Color.Transparent;
            this.lblCompanyName.BackColor = Color.Transparent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            FrmSysControl frmSysControl = new FrmSysControl();
            frmSysControl.Owner = this;
            frmSysControl.Show();
            this.Hide();
        }
    }
}
