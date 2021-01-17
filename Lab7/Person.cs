using System;
namespace Lab7
{
    public class Person
    {
        private string id;
        public string Id

        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name

        {
            get { return name; }
            set { name = value; }
        }

        private string address;
        public string Address

        {
            get { return address; }
            set { address = value; }
        }

        private Account[] accounts;
        private int accountCount;
        public int AccountCount

        {
            get { return accountCount; }
            set { accountCount = value; }
        }

        public Person()

        {
            accounts = new Account[10];
            accountCount = 0;
        }

        public Person(string id, string name, string address)

        {
            this.id = id;
            this.name = name;
            this.address = address;
            accounts = new Account[10];
            accountCount = 0;

        }

        public void AddAccounts(params Account[] accounts)

        {
            foreach (var a in accounts)
            {
                if (accountCount < 10)
                {
                    this.accounts[accountCount++] = a;
                }
                else
                {
                    Console.WriteLine("Can't Create Account:" + a.AccNo);
                }
            }
        }

        public void ShowAllAccounts()

        {
            for (int i = 0; i < accountCount; i++)
            {
                this.accounts[i].ShowInfo();

            }
        }

        public Account SearchAccount(string accNo)
        {
            Account a = null;
            for (int i = 0; i < accountCount; i++)
            {
                if (accounts[i].AccNo.Equals(accNo))
                {
                    a = accounts[i];
                    break;
                }
            }
            return a;
        }

        public void ShowInfo()

        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Id:" + id);
            Console.WriteLine("Address:" + address);
        }
    }

}
