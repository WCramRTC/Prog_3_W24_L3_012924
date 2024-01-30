using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_3_W24_L3_012924
{
    public class Account
    {
        // Instance Fields
        string _name;
        protected double _balance;

        // Static Field
        // add the static key word
        static int _numberOfAccounts;

        public int InstanceNumberOfAccounts { get; private set; }

        public Account(string name, double balance)
        {
            _name = name;
            _balance = balance;

            // Increment the number of accounts by 1
            _numberOfAccounts++;

            //// Increment INSTANCE number of accounts
            InstanceNumberOfAccounts++;
        }

        public string Name { get => _name; set => _name = value; }
        //public double Balance { get => _balance;  }
        public static int NumberOfAccounts { get => _numberOfAccounts; set => _numberOfAccounts = value; }

        public void Deposit(double amount)
        {
            if (amount > 0 && amount < 1000)
            {
                _balance += amount;
            }
        }

        // Static Method

        public static void IncreaseBalance(Account account)
        {
            account._balance += 500;
        }

        public static void TransferMoney(Account from, Account to, double amount)
        {
            // Withdraw the amount from the "from" account
            from._balance -= amount;

            // Deposit the amount into the "to" account
            to._balance += amount;
            
        } 

        public override string ToString()
        {
            return $"Name: {_name}, Balance: ${_balance:F2}";
        }

    }
}
