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
    public partial class FrmTravelStateEdit : Form
    {
        public DisplayUpdate ShowUpdate;

        private TravelStateService objTravelStateService = new TravelStateService();

        public FrmTravelStateEdit()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.ShowUpdate();
        }

        private void GetTravelStateInfoByID(int id)
        {
            List<TravelState> list = objTravelStateService.GetTravelStateInfo(id.ToString(), TravelStateGetDataMode.GET_DATA_MODE_BY_ID);

            if (0 < list.Count)
            {
                this.txtTravelStateName.Text = list[0].TravelStateName;
                this.txtSequenceNumber.Text = list[0].TravelStateSeqNumber.ToString();
                this.rtbTravelStateDescribe.Text = list[0].TravelStateDescribe;
            }
        }

        private void FrmTravelStateEdit_Load(object sender, EventArgs e)
        {
            if (0 == Convert.ToInt32(this.Tag))
            {
                return;
            }
            else
            {
                GetTravelStateInfoByID(Convert.ToInt32(this.Tag));
            }
        }

        private void UpdateTravelStateInfo(TravelStateUpdateDataMode mode)
        {
            TravelState info = new TravelState()
            {
                TravelStateName = this.txtTravelStateName.Text.ToString().Trim(),
                TravelStateSeqNumber = Convert.ToInt32(this.txtSequenceNumber.Text.ToString().Trim()),
                TravelStateDescribe = this.rtbTravelStateDescribe.Text.ToString().Trim(),
            };
            if (TravelStateUpdateDataMode.MODE_INSERT == mode)
            {
                objTravelStateService.UpdateTravelStateInfo(info, null, mode);
            }
            else if (TravelStateUpdateDataMode.MODE_UPDATE == mode)
            {
                info.TravelStateID = Convert.ToInt32(this.Tag);
                objTravelStateService.UpdateTravelStateInfo(info, null, mode);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (0 == Convert.ToInt32(this.Tag))
            {
                UpdateTravelStateInfo(TravelStateUpdateDataMode.MODE_INSERT);
            }
            else
            {
                UpdateTravelStateInfo(TravelStateUpdateDataMode.MODE_UPDATE);
            }

            this.Close();
            this.ShowUpdate();
        }
    }
}
