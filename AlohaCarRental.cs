using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project6_KS_AlohaCarRental
{
    public partial class AlohaCarRental : Form
    {
        private decimal calculateDailyCharge(int days, int carType, decimal dailyCharge, decimal chargePerDay)
        {
            
            if (carType == 1)
            {
                chargePerDay = 20.00m;
            }
            else if (carType == 2)
            {
                chargePerDay = 25.00m;
            }
            else
            {
                chargePerDay = 32.00m;
            }
            dailyCharge = days * chargePerDay;

            return dailyCharge;
        }

        private decimal calculateMileageCharge(int days, int carType, decimal mileageCharge, decimal chargePerMile)
        {
            if (carType == 1)
            {
                chargePerMile = 0.25m;
            }
            else if (carType == 2)
            {
                chargePerMile = 0.35m;
            }
            else
            {
                chargePerMile = 0.40m;
            }
            mileageCharge = days * chargePerMile;
            return mileageCharge;
        }
        public AlohaCarRental()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            customerTextBox.Clear();
            carTypeTextBox.Clear();
            mileageTextBox.Clear();
            daysTextBox.Clear();
            dailyChargeLabel.Text = "";
            mileageChargeLabel.Text = "";
            insurancePlanLabel.Text = "";
            insuranceCostLabel.Text = "";
            totalCostLabel.Text = "";
            customerTextBox.Focus();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //prep
            string customer;
            int carType, days;
            double mileage;

            //vali
            if (!double.TryParse(mileageTextBox.Text, out mileage)|| mileage < 0)
            {
                MessageBox.Show("Enter in the mileage on the rental.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
            if (!int.TryParse(daysTextBox.Text, out days)||days <0)
            {
               MessageBox.Show("Enter in the days on the rental.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            if (!int.TryParse(carTypeTextBox.Text, out carType)|| carType <1 || carType > 3) 
            {
               MessageBox.Show("Enter in the insurance plan type on the rental.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            //useless
            customer = customerTextBox.Text;

            
        }
    }
}
