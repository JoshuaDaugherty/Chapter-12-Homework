using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBreak
{
    public partial class frmGameBreak : Form
    {
        public frmGameBreak()
        {
            InitializeComponent();
        }

        const string GNF = "Game Not Found";
        const string N = "Name:\t";
        const string PUB = "Publisher:\t";
        const string PR = "Price\t";

        string[] gameNames = { "Bluehole", "Roit Games", "Call of Duty: Black Ops 3", "Battlefield 4", "Super Mario Odyssey" };
        decimal[] prices = { 35m, 0m, 60m, 20m, 60m };
        string[] publishers = { "Player Unknowns BattleGrounds", "League of Legends", "Activision", "Nintendo" };


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtSearch.Text = "";
            lblResult.Text = "";
            txtSearch.Focus();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool keepGoing = CheckForNoInput();
            if (keepGoing)
            {
                PerformTheSearch();
            }
        }

        private bool CheckForNoInput()
        {
            bool retVal = true;
            string term = txtSearch.Text.Trim();

            if (term == "")
            {
                ShowErrorMessage("You Must Enter a Search Term",
                    "Search Term Empty");

                ClearForm();
                retVal = false;
            }

            return retVal;
        }

        private void PerformTheSearch()
        {

            string term = txtSearch.Text.Trim();
            bool isFound = false;
            int indexNumber = -1;
            string outputStr = "";

            for (int lcv = 0; lcv < gameNames.Length; lcv++)
            {
                //search name and publisher

                if (gameNames[lcv].ToLower().Contains(term.ToLower()) || publishers[lcv].ToLower().Contains(term.ToLower()))
                {
                    isFound = true;
                    indexNumber = lcv;
                    break;
                }
            }
            //match
            if (isFound)
            {
                outputStr += ($"{N} {gameNames[indexNumber]}\r\t\r\n");
                outputStr += ($"{PUB} {publishers[indexNumber]}\r\n");
                outputStr += ($"{PR} {prices[indexNumber]}\r\n");
            }
            else
            {
                outputStr += ($"{N} {GNF[indexNumber]}\r\t\r\n");
                outputStr += ($"{PUB} {GNF[indexNumber]}\r\n");
                outputStr += ($"{PR} {GNF[indexNumber]}\r\n");
            }

            lblResult.Text = outputStr;

        }
    }
}

