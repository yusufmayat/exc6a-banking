using System;
using System.Collections.Generic;
using System.Text;

namespace exercise_6a.Bank
{
    static class AccountNumberGenerator
    {
        static public int GenerateUniqueAccountNumber (List<Customer> existingCustomers)
        {
            //Generate unique account number 
            int accountNumber = GenerateAccountNumber();

            //Ensure the number is unique by searching through existing customers
            if (existingCustomers == null || existingCustomers.Count == 0)
            {
                return accountNumber;
            }

            int index = 0;

            while (index != -1)
            {
                index = existingCustomers.FindIndex(x => x.AccountNumber == accountNumber);
                accountNumber = GenerateAccountNumber();
            }

            return accountNumber;
        }

        private static int GenerateAccountNumber()
        {
            Random rnd = new Random();
            int value = rnd.Next(11111111, 99999999);
            return value;
        }
    }
}
