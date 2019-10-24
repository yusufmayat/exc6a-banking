using exercise_6a.Bank;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace exercise_6a
{
    class Program
    {

        static List<Customer> Customers = new List<Customer>();
        static List<Account> Accounts = new List<Account>();

        static void Main(string[] args)
        {
            bool temp = true;
            
            while (temp)
            {

                DisplayMenu();

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("You chose to create a new account");
                        CreateCustomer();
                        break;

                    case "2":
                        Console.WriteLine("You chose to view account details");
                        ViewCustomer();
                        break;

                    case "3":
                        Console.WriteLine("You chose to edit details");
                        EditCustomer();

                        break;

                    case "4":

                        break;

                    case "5":
                        Console.WriteLine("You chose to exit the program");
                        temp = false; 
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again");
                        break;
                }
            }
        }

        private static void EditCustomer()
        {
            Console.WriteLine("What is your account number");
            int inputAccountNumber = int.Parse(Console.ReadLine());

            int index = Customers.FindIndex(x => x.AccountNumber == inputAccountNumber);

            if (index != -1)
            {
                bool temp = true;
                Console.WriteLine("******************************************");
                Console.WriteLine("1. Forename");
                Console.WriteLine("2. Surname");
                Console.WriteLine("3. Address");
                Console.WriteLine("4. Email");
                Console.WriteLine("5. Exit edit details");
                Console.WriteLine("******************************************");
                Console.WriteLine("Input the corresponding number for the detail you would like to edit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    default:

                        break;
                }



            }
            else
            {
                Console.WriteLine("Invalid account number entered");
            }

        }

        private static void ViewCustomer()
        {
            Console.WriteLine("What is your account number");
            int inputAccountNumber = int.Parse(Console.ReadLine());

            int index = Customers.FindIndex(x => x.AccountNumber == inputAccountNumber);

            if (index != -1)
            {
                Console.WriteLine("Forename: " + Customers[index].ForeName);
                Console.WriteLine("Surname: " + Customers[index].SurName);
                Console.WriteLine("Address: " + Customers[index].Address);
                Console.WriteLine("Email: " + Customers[index].Email);
                Console.WriteLine("Balance: " + Accounts[index].Balance);
            }
            else
            {
                Console.WriteLine("Invalid account number entered");
            }
           
        }

        private static void CreateCustomer()
        {
            bool temp = true;
            int accountNumber = AccountNumberGenerator.GenerateUniqueAccountNumber(Customers);

            Console.WriteLine("What is your forename");
            var foreName = Console.ReadLine();
            Console.WriteLine("What is your surname");
            var surName = Console.ReadLine();
            Console.WriteLine("What is your address");
            var address = Console.ReadLine();
            var email = "";
            while (temp)
            {
                Console.WriteLine("What is your email");
                string femail = Console.ReadLine();
                bool hold = CheckEmail(femail);
               
                if (hold == true)
                {
                    email = femail;
                    temp = false;
                }
                else
                {
                    Console.WriteLine("Email invalid. Please try again");
                }
            }
            Console.WriteLine("Account created");
            Console.WriteLine("Your account number is {0}", accountNumber);
            var newCustomer = new Customer(accountNumber, foreName, surName, address, email);
            var newAccount = new Account(accountNumber);
            Customers.Add(newCustomer);
            Accounts.Add(newAccount);

        }

        private static bool CheckEmail(string femail)
        {
            string expression = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(femail, expression))
            {
                if (Regex.Replace(femail, expression, string.Empty).Length == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("1. New customer");
            Console.WriteLine("2. View details/balance"); // take input of an account 
            Console.WriteLine("3. Edit details");
            Console.WriteLine("4. Withdraw/Deposit money");
            Console.WriteLine("5. Exit program");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Enter the corresponding number for your choice");
        }
    }
}
