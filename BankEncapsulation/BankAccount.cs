using System;
namespace BankEncapsulation
{
	public class BankAccount
    {
		

		public BankAccount()
        {
        }

        private double balance = 0;

		public void Deposit(double amount)
		{
			
			balance += amount;
		}

		public double GetBalance()
		{
			return balance;
		}
    }
}

