using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeService
{
    public partial class frmHomeService : Form
    {
        public frmHomeService()
        {
            InitializeComponent();
            //assign initial values to the labels
            //desc is the name of label
            txtDescription.Text = "Wash Windows";

            //hour is the name of label
            txtHours.Text = "3.5 hours";

            //rate is the name of label
            txtRate.Text = "$25.00";

            //fee is the name of label
            lblTotal.Text = "$122.5";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitForm();
        }

        private void ExitForm()
        {
            DialogResult dialog = MessageBox.Show(
        "Do You Really Want To Exit The Program?",
        "EXIT NOW?",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtDescription.Text = "";
            txtHours.Text = "";
            txtRate.Text = "";
            lblTotal.Text = "";
            txtDescription.Focus();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //take values from textbox on button click
            string descrip = txtDescription.Text;
            float htc = float.Parse(txtHours.Text);
            float hourlyFee = float.Parse(txtRate.Text);

            //create object of job class
            Job ob = new Job(descrip, htc, hourlyFee);

            //change the value of labels accordingly
            //formate label upto two deciaml places
            txtDescription.Text = ob.getDescription();
            txtHours.Text = String.Format("{0:0.00}", ob.getHourToComplete()) + " hours";
            txtRate.Text = "$" + String.Format("{0:0.00}", ob.getHourlyFee());
            lblTotal.Text = "$" + String.Format("{0:0.00}", ob.getTotalFee());


        }
    }
}
