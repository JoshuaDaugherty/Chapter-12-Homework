using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesDB
{
    public partial class frmMovies : Form
    {
        public frmMovies()
        {
            InitializeComponent();
        }

        const string MNF = "Movie Not Found";
        const string N = "Name:\t";
        const string DIR = "Director:\t";
        const string DES = "Description\t";

        string[] movieNames = { "Black Panther", "The Batman", "Avatar", "Scream", "Halloween", "Thor", "King Kong", "Godzilla", "Minions", "Despicable Me", "Transformers" };
        string[] Director = { "Ryan Coogler", "Matt Reeves", "James Cameron", "Wes Craven", "Rob Zombie", "Taika Waititi", "Peter Jackson", "Takashi Yamazaki", "Pierre Coffin", "Pierre Coffin", "Michael Bay" };
        string[] Description = {"Interesting movie about Wakanda", "Cool vigilante", "Cool movie about blue people", "Horror slasher movie", "Deranged Killer", "Shocking super hero", "Mutant ape from lost island", "Insane monster that protects people",
        "Funny movie for kids", "Funny Super villian", "Autobot Roll out"};

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

            for (int lcv = 0; lcv < movieNames.Length; lcv++)
            {
                //search name and publisher

                if (movieNames[lcv].ToLower().Contains(term.ToLower()) || Description[lcv].ToLower().Contains(term.ToLower()))
                {
                    isFound = true;
                    indexNumber = lcv;
                    break;
                }
            }
            //match
            if (isFound)
            {
                outputStr += ($"{N} {movieNames[indexNumber]}\r\t\r\n");
                outputStr += ($"{DES} {Description[indexNumber]}\r\n");
                outputStr += ($"{DIR} {Director[indexNumber]}\r\n");
            }
            else
            {
                outputStr += ($"{N} {MNF[indexNumber]}\r\t\r\n");
                outputStr += ($"{DIR} {MNF[indexNumber]}\r\n");
                outputStr += ($"{DES} {MNF[indexNumber]}\r\n");
            }

            lblResult.Text = outputStr;

        }
    }
}
