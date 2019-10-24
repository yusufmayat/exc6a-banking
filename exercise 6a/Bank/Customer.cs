using System;

namespace exercise_6a.Bank
{
    class Customer
    {
        private int _AccountNumber;
        private string _ForeName;
        private string _SurName;
        private string _Address;
        private string _Email;

        public Customer(int accountNumber, string foreName, string surName, string address, string email )
        {
            _AccountNumber = accountNumber;
            _ForeName = foreName;
            _SurName = surName;
            _Address = address;
            _Email = email;
        }

        public int AccountNumber { get => _AccountNumber; }
        public string ForeName { get => _ForeName;  }
        public string SurName { get => _SurName;  }
        public string Address { get => _Address;  }
        public string Email { get => _Email;  }

    }
}
