using IntroducingClassType.Models;
using System;

namespace IntroducingClassType
{
    class Program
    {
        static void Main()
        {
            TestDefaultBankAccount dd = new TestDefaultBankAccount("a", "j", 5);
            var ff = dd.Number;
            SimpleClassExample();
            DefaultConstructor();
            DefiningCustomConstructors();
            ConstructorsWithOutParameters();
            UnderstandingDefaultConstructorRevisited();
            ObservingConstructorFlow();

            Console.ReadLine();
        }

        static void SimpleClassExample()
        {
            Console.WriteLine("************************************* Simple Class Example *************************************");

            TestBankAccount ba = new TestBankAccount();
            ba.PrintCurrentState();

            ba.Owner = "Poghos Poghosyan";
            ba.PrintCurrentState();

            // Compiler error! Forgot to use 'new' to create object!
            //TestBankAccount newBA;
            //newBA.Owner = "Illegal Action";

            // Define and allocate a class instance on separate lines of code,
            TestBankAccount premiumAccount;
            premiumAccount = new TestBankAccount();
            premiumAccount.Owner = "Big Boss";
            premiumAccount.PrintCurrentState();
        }

        static void DefaultConstructor()
        {
            Console.WriteLine("\n************************************* Default Constructor Example *************************************");

            BankAccount ba = new BankAccount();
            ba.PrintCurrentState();
        }

        static void DefiningCustomConstructors()
        {
            Console.WriteLine("\n************************************* Defining Custom Constructors Example *************************************");

            BankAccount ba1 = new BankAccount("54654966946", "First User", 202100);
            ba1.PrintCurrentState();

            BankAccount ba2 = new BankAccount("54654966946", 202100, "First User");
            ba2.PrintCurrentState();

            BankAccount ba3 = new BankAccount(("54654966946", "First User", 202100));
            ba3.PrintCurrentState();

            BankAccount ba4 = new BankAccount("00098989");
            ba4.PrintCurrentState();
        }

        // Constructors with out Parameters (New 7.3)
        static void ConstructorsWithOutParameters()
        {
            Console.WriteLine("\n************************************* Constructors with out Parameters *************************************");
            BankAccount ba = new BankAccount("789255665", "Old User", 258794, out bool isExpired);
            ba.PrintCurrentState();
            Console.WriteLine($"Is Expired: {isExpired}\n");

            ba = new BankAccount("44511119887", "Bad User", -2500, out bool isExpired2);
            ba.PrintCurrentState();
            Console.WriteLine($"Is Expired: {isExpired2}\n");
        }
                
        static void UnderstandingDefaultConstructorRevisited()
        {
            Console.WriteLine("\n*************************** Default constructor is silently removed ***************************");
            // Compiler error!
            // As soon as you define a custom constructor with any number of parameters, the default
            // constructor is silently removed from the class and is no longer available.
            //TestDefaultBankAccount baDefault = new TestDefaultBankAccount();
            //baDefault.PrintCurrentState();

            TestDefaultBankAccount ba = new TestDefaultBankAccount("0000000000000001", "Test User", 7895200 );
            ba.PrintCurrentState();
        }

        static void ObservingConstructorFlow()
        {
            Console.WriteLine("\n*************************** Observing Constructor Flow ***************************");
            BankAccountConstructorFlow ba1 = new BankAccountConstructorFlow("0000000000000001");
            ba1.PrintCurrentState();

            BankAccountConstructorFlow ba2 = new BankAccountConstructorFlow(2021000);
            ba2.PrintCurrentState();
        }
    }
}