using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            var bookstore = new Company("The Bookworm", new DateTime(2021, 3,2,7,0,0));
            // Create three employees
            var employeeA = new Employee("Edgar Alan", "Poe", "Mystery Writer", new DateTime(2021,3,13,7,0,0));
            var employeeB = new Employee("Jane", "Austen", "Romance Writer", new DateTime(2021,6,4,8,0,0));
            var employeeC = new Employee("Tom", "Clancy", "Thriller Writer", new DateTime(2021,1,4,12,4,0));
            // Assign the employees to the company
            bookstore.Employees.Add(employeeA);
            bookstore.Employees.Add(employeeB);
            bookstore.Employees.Add(employeeC);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            bookstore.ListEmployees();
        }
    }
}

