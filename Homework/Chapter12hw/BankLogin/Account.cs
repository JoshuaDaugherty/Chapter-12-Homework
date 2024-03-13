using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLogin
{
    public class Account
    {
        public decimal MINBALANCE = 25.00m;

        private readonly string _title;
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly string _accountNumber;
        private readonly string _pinNumber;
        private decimal _balance;

        //full arg

        public Account(string title, string firstName, string lastName, string accountNumber, string pinNumber, decimal balance)
        {
           _title = title;
            _firstName = firstName;
            _lastName = lastName;
            _accountNumber = accountNumber;
            _pinNumber = pinNumber;

            _balance = balance;
        }

        //getters

        public string GetTitle() => _title;
        public string GetfirstName() => _firstName;

        public string GetlastName() => _lastName;
        public string GetaccountNumber() => _accountNumber;
        public decimal Getbalance() => _balance;

        public string GetpinNumber() => _pinNumber;

        //Attempt deposit
        public void MakeDeposit(decimal deposit)
        {
            //local to hold a copy of attempted deposit
            decimal theDeposit = deposit;
            try
            {
                //attempt to make deposit
                //check for negative deposit
                if (theDeposit <= 0)
                {
                    throw new ArgumentOutOfRangeException();

                    
                }
                //deposit was not negative
                _balance += theDeposit;

            }
            catch (ArgumentOutOfRangeException aoore) 
            {
                MessageBox.Show("System Message:\t" +aoore.Message +
                    "Illegal Deposit. Must be > 0 ", "Illegal Deposit Attempted");

                return;
            }

        }
        //attempt to withdraw
        public void MakeWithdrawal(decimal withdrawal)
        {

            //local to hold a copy of attempted deposit
            decimal theWithdrawal = withdrawal;
            decimal tempValue = -1;
            try
            {
                //atempt to make withdrawal
                if (theWithdrawal <= 0)
                {
                    throw new ArgumentOutOfRangeException();


                }
                //withdrawal was not negative
                //Attempt to make withdrawal
                //check make sure the balance is great then or equal to 25 bucks
                tempValue = _balance - withdrawal;

                if (tempValue >= MINBALANCE)
                {
                    _balance -= withdrawal;
                }
                else
                {
                    //
                    throw new DataException();
                }

            }
            catch (DataException de)
            {
                MessageBox.Show("System Message:\t" + de.Message +
                   "Illegal Withdrawal. Must be > 0 ", "Illegal Withdrawal Attempted");

                return;
            }

            catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show("System Message:\t" + aoore.Message +
                    "Illegal Withdrawal. Must be > 0 ", "Illegal Withdrawal Attempted");

                return;
            }
        }
    }
}
