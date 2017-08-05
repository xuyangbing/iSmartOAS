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
    public partial class FrmDayOffStateEdit : Form
    {
        public DisplayUpdate ShowUpdate;

        public DayOffStateService objDayOffStateService = new DayOffStateService();

        public FrmDayOffStateEdit()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.ShowUpdate();
        }

        private void FrmDayOffStateEdit_Load(object sender, EventArgs e)
        {
            if (0 == Convert.ToInt32(this.Tag))
            {

            }
            else
            {
                GetDayOffStateInfoByID(Convert.ToInt32(this.Tag));
            }
        }

        private void GetDayOffStateInfoByID(int id)
        {
            List<DayOffState> list = objDayOffStateService.GetDayOffStateInfo(id.ToString(), DayOffStateGetDataMode.GET_DATA_BY_ID);

            if (0 < list.Count)
            {
                this.txtDayOffStateName.Text = list[0].DayOffStateName;
                this.txtSequenceNumber.Text = list[0].SequenceNumber.ToString();
                this.rtbDayOffStateDescribe.Text = list[0].DayOffStateDescribe;
            }
        }

        private void UpdateDayOffStateInfo(DayOffStateUpdateMode mode)
        {
            DayOffState objDayOffState = new DayOffState()
            {
                DayOffStateName = this.txtDayOffStateName.Text.ToString().Trim(),
                DayOffStateDescribe = this.rtbDayOffStateDescribe.Text.ToString(),
                SequenceNumber = Convert.ToInt32(this.txtSequenceNumber.Text)
            };

            if (DayOffStateUpdateMode.MODE_INSERT == mode)
            {
                objDayOffStateService.UpdateDayOffStateInfo(objDayOffState, null, mode);
            }

            if (DayOffStateUpdateMode.MODE_UPDATE == mode)
            {
                objDayOffState.DayOffStateID = Convert.ToInt32(this.Tag);
                objDayOffStateService.UpdateDayOffStateInfo(objDayOffState, null, mode);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (0 == Convert.ToInt32(this.Tag))
            {
                UpdateDayOffStateInfo(DayOffStateUpdateMode.MODE_INSERT);
            }
            else
            {
                UpdateDayOffStateInfo(DayOffStateUpdateMode.MODE_UPDATE);
            }

            this.Close();
            this.ShowUpdate();

        }
    }
}
