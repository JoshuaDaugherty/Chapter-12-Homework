using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLogin
{
    public partial class frmBankLogin : Form
    {
        //list of accounts
        List<Account> accounts = new List<Account>();
        string whichAccountNumber = "";
        string whichPinNumber = "";
        int accountNumberLocation = 0;
        int pinNumberLocation = 0;
        bool LoggedIn = false;
        
     
        public frmBankLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AttemptLogin();
        }

        private void AttemptLogin()
        {
            bool keepGoing = ValidateAccountNumber();  

            if (keepGoing)
            {
                keepGoing = ValidatePinNumber();
            }
            else
            {
                return;
            }
            //debugging
            //MessageBox.Show("accountNumberLocation = " + accountNumberLocation + "\n" +
            //    "pinNumberLocation = " +
            //    pinNumberLocation,
            //    "LOCATIONS");
            if(accountNumberLocation == -1 || pinNumberLocation == -1 || accountNumberLocation != pinNumberLocation)
            {
                LoggedIn = false;
                ShowErrorMessage("Account and pin Number dont Error", "ACCOUNT NUMBER AND OR PIN NUMBER ERROR");

                return;
            }
            if (accountNumberLocation == pinNumberLocation)
            {
                LoggedIn = true;
                DisplayCustomerInformation();
            }
            else
            {
                ShowErrorMessage("Account and pin Number dont Match", "Bad account number and or pin number");

                return;
            }
        }

        private bool ValidateAccountNumber()
        {
            string acctNumber = txtAccount.Text.Trim();
            //Look for the acctNumber int the list of customers
            for (int lcv = 0; lcv < accounts.Count; lcv++)
            {
                if(acctNumber == accounts[lcv].GetaccountNumber())
                {
                    whichAccountNumber = acctNumber;
                    accountNumberLocation = lcv;
                    return true;
                }
            }
            ShowErrorMessage("That Account Number Does Not Exist!", "INVALID ACCOUNT NUMBER");
            txtAccount.Text = "";
            txtAccount.Focus();
            accountNumberLocation = -1;
            return false;
        }

        private bool ValidatePinNumber()
        {
            string pinNumber = txtPin.Text.Trim();
            //Look for the PinNumber int the list of customers
            for (int lcv = 0; lcv < accounts.Count; lcv++)
            {
                if (pinNumber == accounts[lcv].GetpinNumber())
                {
                    whichPinNumber = pinNumber;
                    accountNumberLocation = lcv;
                    return true;
                }
            }
            ShowErrorMessage("That pin Number Does Not Exist!", "INVALID PIN NUMBER");
            txtPin.Text = "";
            txtPin.Focus();
            pinNumberLocation = -1;
            return false;
        }

        public void DisplayCustomerInformation()
        {
            lblResult.Text = "";
            int local = accountNumberLocation;

            string outputStr = "";
            outputStr +="welcome" +  accounts[local].GetTitle() + "" + accounts[local].GetfirstName() +
                "" + accounts[local].GetlastName() + "\n\n" + "Your Current Balance:\t" + accounts[local].Getbalance().ToString("c");

            lblResult.Text = outputStr;
            postDisableControls();
        }

        private void postDisableControls()
        {
            LoggedIn = true;
            btnLogin.Enabled = false;
            btnLogout.Enabled = true;
            btnDeposit.Enabled = true;
            btnWithdraw.Enabled = true;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           DisableControls();
            txtAccount.Focus();
        }

        private void DisableControls()
        {
            LoggedIn = false;
            btnLogin.Enabled = true;
            btnLogout.Enabled = false;
            btnDeposit.Enabled = false;
            btnWithdraw.Enabled = false;

            whichAccountNumber = "";
             whichPinNumber = "";
             accountNumberLocation = 0;
             pinNumberLocation = 0;

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            AttemptDeposit();
        }
        private void AttemptDeposit()
        {
            bool result;
            decimal deposit = 0.00m;
            string depositStr = txtDeposit.Text.Trim();

            if (string.IsNullOrEmpty(depositStr))
            {
                ShowErrorMessage("You Must enter a positive number", "invalid number");
            }

            try
            {
                result = decimal.TryParse(depositStr, out deposit);
                if (!result)
                {
                    throw new FormatException();
                }

                accounts[accountNumberLocation].MakeDeposit(deposit);
                DisplayCustomerInformation();
            }
            catch (FormatException fe)
            {
                ShowErrorMessage("System Messgae:\t" + fe.Message + "\n\n" + "Non-Numeric Input", "ILLEGAL DEPOSIT VALUE");
            }

        }
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            AttemptWithdrawal();
        }
        private void AttemptWithdrawal()
        {

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
            { }

            
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void frmBankLogin_Load(object sender, EventArgs e)
        {
            accounts.Add(new Account("Mr.", "Jeffery", "Scott", "123-45-6789", "1234", 10000.00m));
            accounts.Add(new Account("Mr.", "Evan", "Gudmestad", "234-56-7890", "2345", 2578.00m));
            accounts.Add(new Account("Mr.", "Doug", "Gegglemen", "345-67-8901", "3456", 7654.00m));
            accounts.Add(new Account("Mr.", "James", "Kaufman", "456-78-6789", "4567", 87654.00m));
            accounts.Add(new Account("Ms.", "Shannon", "Cirrigan", "567-89-0123", "5678", 782.00m));

            DisableControls();
        }
    }
}
