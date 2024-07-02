using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrouble
{
    public partial class frmBugTrouble : Form
    {
        public frmBugTrouble()
        {
            InitializeComponent();
        }

        private void btnCalculateWhenHouseIsFull_Click(object sender, EventArgs e)
        {
            decimal volumeOfYourHouseInCubicFeet = Convert.ToDecimal(txtVolumeOfYourHouseInCubicFeet.Text);
            decimal numberOfRoachesInYourHouse = Convert.ToDecimal(txtNumberOfRoachesInYourHouse.Text);
            int weeksUntilHouseIsFull = 0;
            //do
            //{
            //    numberOfRoachesInYourHouse = numberOfRoachesInYourHouse + (numberOfRoachesInYourHouse * 0.95m);
            //    weeksUntilHouseIsFull++;
            //}
            //while ((numberOfRoachesInYourHouse * 0.002m) <= volumeOfYourHouseInCubicFeet);

            for (weeksUntilHouseIsFull = 0; (numberOfRoachesInYourHouse * 0.002m) <= volumeOfYourHouseInCubicFeet; weeksUntilHouseIsFull++)
            {
                numberOfRoachesInYourHouse = numberOfRoachesInYourHouse + (numberOfRoachesInYourHouse * 0.95m);
            }

            txtWeeksUntilHouseIsFull.Text = weeksUntilHouseIsFull.ToString();
            txtTotalNumberOfRoaches.Text = Math.Round(numberOfRoachesInYourHouse).ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
