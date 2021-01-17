using System;
namespace Lab7
{
    public class Employee
    {
        private string name;
        public string Name

        {
            get { return name; }
            set { name = value; }
        }

        private string id;
        public string Id

        {
            get { return id; }
            set { id = value; }
        }

        public Employee()
        {
        }

        public Employee(string name, string id)

        {
            this.name = name;
            this.id = id;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Id:" + id);
        }

    }
}
