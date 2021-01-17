using System;
namespace Lab7
{
    public class Savings:Account

    {
        int transaction = 0;
        int minimalNo = 5;

        public Savings(string name, string accNo, double balance) : base(name, accNo, balance)
        {

        }

        override public void Deposit(double amount)

        {

            if (transaction >= minimalNo)

            {
                Console.WriteLine("Can't Have Any More Transaction For This Month");
            }

            else
            {
                this.balance = this.balance + amount;
                transaction++;
            }

        }
        public override void Withdraw(double amount)
        {
            if (balance - amount >= 500)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("Insufficient Balance To Withdraw");
        }


    }

}
