using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();

            while (true)
            {
                Console.WriteLine("How much would you like to deposit?");

                var input = Console.ReadLine();
                if (!double.TryParse(input, out var amountToDeposit))
                {
                    Console.WriteLine("Invalid amount. Please enter a number.");
                    continue;
                }

                try
                {
                    myAccount.Deposit(amountToDeposit);
                    Console.WriteLine($"Thank you! Your balance is now {myAccount.GetBalance():C}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Would you like to make anymore deposits? (y/n)");
                var answer = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(answer)) break;
                var first = answer.Trim().ToLower()[0];
                if (first == 'y') continue;
                if (first == 'n')
                {
                    Console.WriteLine($"Thank you, Your balance is now {myAccount.GetBalance():C}, have a good day!");
                }
                break;
            }
        }
    }
}
