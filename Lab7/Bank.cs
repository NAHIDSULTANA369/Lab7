using System;
namespace Lab7
{
    public class Bank
    {
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

        private Employee[] employees;
        private int employeeCount;
        public int EmployeeCount

        {
            get { return employeeCount; }
            set { employeeCount = value; }
        }

        private Person[] persons;
        private int personCount;
        public int PersonCount

        {
            get { return personCount; }
            set { personCount = value; }

        }

        public Bank()

        {
            employees = new Employee[100];
            persons = new Person[500];
            employeeCount = 0;
            PersonCount = 0;
        }

        public Bank(string name)

        {
            employees = new Employee[100];
            persons = new Person[500];
            employeeCount = 0;
            PersonCount = 0;
        }

        public void AddEmployee(params Employee[] employees)

        {
            foreach (var emp in employees)
            {
                if (employeeCount < 100)
                    this.employees[employeeCount++] = emp;
                else
                    Console.WriteLine("Can't add Employee");
            }
        }

        public void ShowAllEmployees()

        {
            for (int i = 0; i < employeeCount; i++)
            {
                employees[i].ShowInfo();

            }
        }

        public Employee SearchEmployee(string id)

        {
            Employee e = null;
            for (int i = 0; i < employeeCount; i++)
            {
                if (id.Equals(employees[i].Id))
                {
                    e = employees[i];
                    break;
                }
            }

            return e;
        }

        public void AddPersons(params Person[] persons)

        {
            foreach (var p in persons)
            {
                if (PersonCount < 500)
                {
                    persons[PersonCount++] = p;
                }
                else
                {
                    Console.WriteLine("Can't add Person");
                }
            }
        }

        public void ShowAllPersons()

        {
            for (int i = 0; i < personCount; i++)
            {
                persons[i].ShowInfo();
            }
        }

        public Person SearchPerson(string id)

        {
            Person p = null;
            for (int i = 0; i < personCount; i++)
            {
                if (persons[i].Id.Equals(id))
                {
                    p = persons[i];
                    break;
                }

            }

            return p;
        }
    }
}
