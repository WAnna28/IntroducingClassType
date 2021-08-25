using System;

namespace IntroducingClassType.Models
{
    public class BankAccount
    {
        private string Number;
        public string Owner;
        private decimal Balance;

        // Every C# class is provided with a “freebie” default constructor that you can redefine if need be.
        // By definition, a default constructor never takes arguments.
        // After allocating the new object into memory,
        // the default constructor ensures that all field data of the class is set to an appropriate default value
        public BankAccount()
        {
            Number = "34582021451001";
            Owner = "Test Test";
            Balance = 20154;
        }

        #region Defining Custom Constructors

        public BankAccount(string number, string owner, decimal balance)
        {
            Number = number;
            Owner = owner;
            Balance = balance;
        }

        // changed place of arguments
        public BankAccount(string number, decimal balance, string owner)
        {
            Number = number;
            Owner = owner;
            Balance = balance;
        }

        public BankAccount((string number, string owner, decimal balance) ba)
        {
            Number = ba.number;
            Owner = ba.owner;
            Balance = ba.balance;
        }


        public BankAccount(string number)
        {
            Number = number;
            Owner = "Unknown User";
            Balance = 0;
        }

        #endregion

        // Constructors with out Parameters (New 7.3)
        public BankAccount(string number, string owner, decimal balance, out bool isExpired)
        {
            Number = number;
            Owner = owner;
            Balance = balance;

            isExpired = balance <= 0;
        }

        public void PrintCurrentState()
        {
            Console.WriteLine($"Card number: {Number}. \nOwner: {Owner}. \nBalance: {Balance}.\n");
        }
    }
}