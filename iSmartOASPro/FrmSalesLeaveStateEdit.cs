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
    public partial class FrmSalesLeaveStateEdit : Form
    {
        public DisplayUpdate ShowUpdate;

        private SalesLeaveStateService objSalesLeaveStateService = new SalesLeaveStateService();

        public FrmSalesLeaveStateEdit()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.ShowUpdate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SalesLeaveState info = new SalesLeaveState();
            info.SalesLeaveStateName = txtSalesLeaveStateName.Text.ToString().Trim();
            info.SalesLeaveStateSeqNumber = Convert.ToInt32(txtSequenceNumber.Text);
            info.SalesLeaveStateDescribe = this.rtbSalesLeaveStateDescribe.Text.ToString();

            if (0 == Convert.ToInt32(this.Tag))
            {
                objSalesLeaveStateService.UpdateSalesLeaveStateInfo(info, null, SalesLeaveStateUpdateDataMode.MODE_INSERT);
            }
            else
            {
                info.SalesLeaveStateID = Convert.ToInt32(this.Tag);
                objSalesLeaveStateService.UpdateSalesLeaveStateInfo(info, null, SalesLeaveStateUpdateDataMode.MODE_UPDATE);
            }

            this.Close();
            this.ShowUpdate();
        }

        private void GetSalesLeaveStateByID(int id)
        {
            List<SalesLeaveState> list = objSalesLeaveStateService.GetSalesLeaveStateInfo
                (
                    id.ToString(), 
                    SalesLeaveStateGetDataMode.GET_DATA_MODE_BY_ID
                );

            if (0 < list.Count)
            {
                this.txtSalesLeaveStateName.Text = list[0].SalesLeaveStateName.ToString();
                this.txtSequenceNumber.Text = list[0].SalesLeaveStateSeqNumber.ToString();
                this.rtbSalesLeaveStateDescribe.Text = list[0].SalesLeaveStateDescribe.ToString();
            }
        }

        private void FrmSalesLeaveStateEdit_Load(object sender, EventArgs e)
        {
            if (0 == Convert.ToInt32(this.Tag))
            {
                return;
            }
            else
            {
                GetSalesLeaveStateByID(Convert.ToInt32(this.Tag));
            }
        }


    }
}
