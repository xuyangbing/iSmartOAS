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
    public partial class GoOutStateEdit : Form
    {
        public DisplayUpdate ShowUpdate;

        GoOutStateService objGoOutStateService = new GoOutStateService();

        public GoOutStateEdit()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.ShowUpdate();
        }

        private void GoOutStateEdit_Load(object sender, EventArgs e)
        {
            if (0 == Convert.ToInt32(this.Tag))
            {

            }
            else
            {
                GetGoOutStateInfoByID(Convert.ToInt32(this.Tag));
            }

        }

        private void GetGoOutStateInfoByID(int id)
        {
            List<GoOutState> list = objGoOutStateService.GetGoOutStateInfo(id.ToString(), GoOutStateGetDataMode.GET_DATA_MODE_BY_ID);

            if (0 < list.Count)
            {
                this.txtGoOutStateName.Text = list[0].GoOutStateName;
                this.txtSequenceNumber.Text = list[0].GoOutStateSeqNumber.ToString();
                this.rtbGoOutStateDescribe.Text = list[0].GoOutStateDescribe;
            }
        }

        private void UpdateGoOutStateInfo(GoOutStateUpdateMode mode)
        {
            GoOutState info = new GoOutState()
            {
                GoOutStateName = this.txtGoOutStateName.Text.ToString().Trim(),
                GoOutStateSeqNumber = Convert.ToInt32(this.txtSequenceNumber.Text),
                GoOutStateDescribe = this.rtbGoOutStateDescribe.Text.ToString()
            };

            if (GoOutStateUpdateMode.MODE_INSERT == mode)
            {
                objGoOutStateService.UpdateGoOutStateInfo(info, null, mode);
            }

            if (GoOutStateUpdateMode.MODE_UPDATE == mode)
            {
                info.GoOutStateID = Convert.ToInt32(this.Tag);
                objGoOutStateService.UpdateGoOutStateInfo(info, null, mode);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (0 == Convert.ToInt32(this.Tag))
            {
                UpdateGoOutStateInfo(GoOutStateUpdateMode.MODE_INSERT);
            }
            else
            {
                UpdateGoOutStateInfo(GoOutStateUpdateMode.MODE_UPDATE);
            }

            this.Close();
            this.ShowUpdate();
        }
    }
}
