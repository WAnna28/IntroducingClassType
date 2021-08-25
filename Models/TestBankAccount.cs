using System;

namespace IntroducingClassType.Models
{
    public class TestBankAccount
    {
        private string Number;
        public string Owner;
        private decimal Balance;

        public void PrintCurrentState()
        {
            Console.WriteLine($"Card number: {Number}. \nOwner: {Owner}. \nBalance: {Balance}.\n");
        }
    }
}
