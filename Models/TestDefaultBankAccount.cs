using System;

namespace IntroducingClassType.Models
{
    public class TestDefaultBankAccount
    {
        public string Number;
        public string Owner;
        private decimal Balance;

        // As soon as you define a custom constructor with any number of parameters, the default
        // constructor is silently removed from the class and is no longer available.
        public TestDefaultBankAccount(string number, string owner, decimal balance)
        {
           // Number = number;
            Owner = owner;
            Balance = balance;
        }

        // Put back the default constructor, which will
        // set all data members to default values.
        // public TestDefaultBankAccount() { }

        // DO TOGETHER 
        // the ctor CODE SNIPPET

        public void PrintCurrentState()
        {
            Console.WriteLine($"Card number: {Number}. \nOwner: {Owner}. \nBalance: {Balance}.\n");
        }
    }
}
