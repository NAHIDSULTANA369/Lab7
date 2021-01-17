using System;

namespace Lab7
{
    class Program

    {
        static void Main(string[] args)
        {

            Bank b = new Bank("Janata Bank");
            Employee e1 = new Employee("Nahid", "3303");
            Employee e2 = new Employee("Asif", "3333");
            Employee e3 = new Employee("Antor", "5633");
            b.AddEmployee(e1, e2, e3);

            Person p = new Person("323", "Nahid", "Chandpur");
            Account a1 = new Savings("Nahid", "123", 10000);
            p.AddAccounts(a1);

            Console.WriteLine();
            Console.WriteLine("Savings Account");
            Account a2 = new Savings("Asif", "1234", 10000);
            Savings a3 = new Savings("Antor", "3434", 10000);
            Console.WriteLine();
            a3.ShowInfo();
            a3.Deposit(3000);
            a3.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("Savings Account Withdraw");
            Console.WriteLine();
            a3.Withdraw(500);
            a3.ShowInfo();

            Console.WriteLine();
            Console.WriteLine("OverDraft Account");
            Console.WriteLine();
            Overdraft o1 = new Overdraft("Pink", "111", 10000);
            Overdraft o2 = new Overdraft("Peu", "122", 10000);
            Console.WriteLine();
            o1.ShowInfo();
            o1.Deposit(3000);
            o1.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("OverDraft Account Withdraw");
            Console.WriteLine();

            o2.Withdraw(1000);
            o2.ShowInfo();

        }
    }

}
