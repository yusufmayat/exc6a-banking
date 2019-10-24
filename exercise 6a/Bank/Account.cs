using System;
using System.Collections.Generic;
using System.Text;

namespace exercise_6a.Bank
{
    class Account
    {
        private int _AccountNumber;
        private decimal _balance = 0;
        
        public int AccountNumber { get => _AccountNumber; }
        public decimal Balance { get => _balance; }

        // Account number is same as customer account number
        public Account(int accountNumber)
        {
            _AccountNumber = accountNumber;
        }

        public void Credit(decimal amount)
        {
            _balance += amount; 
        }

        public void Debit(decimal amount)
        {
            _balance -= amount; 
        }

        



    }
}
