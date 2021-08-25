using System;

namespace IntroducingClassType.Models
{
    public class BankAccountConstructorFlow
    {
        private string Number;
        public string Owner;
        private decimal Balance;

        public BankAccountConstructorFlow()
        {
            Console.WriteLine("Default ctor");
        }

        public BankAccountConstructorFlow(decimal d) : this("", d, "")
        {            
            Console.WriteLine("ctor taking an DECIMAL");
        }

        public BankAccountConstructorFlow(string n) : this(n, 0, "")
        {
            Console.WriteLine("ctor taking a STRING");
        }

        public BankAccountConstructorFlow(string n, decimal d) : this(n, d, "")
        {
            Console.WriteLine("ctor taking a STRING and a DECIMAL");
        }

        public BankAccountConstructorFlow(string number, decimal balance, string owner)
        {
            Console.WriteLine("Master ctor");
            Number = number;
            Owner = owner;
            Balance = balance;
        }

        public void PrintCurrentState()
        {
            Console.WriteLine($"Card number: {Number}. \nOwner: {Owner}. \nBalance: {Balance}.\n");
        }
    }
}
