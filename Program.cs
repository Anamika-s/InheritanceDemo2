using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Details");
            Employee employee = new Employee();
            employee.GetDetails();
            employee.DisplayDetails();


            Console.WriteLine("Full Employee Details");
            FullTimEmployee fullTimEmployee = new FullTimEmployee();
            fullTimEmployee.GetDetails();
            //fullTimEmployee.GetFullTimEmployeeDetails();
            fullTimEmployee.DisplayDetails();
            //fullTimEmployee.DisplayFullTimEmployeeDetails();

            Console.WriteLine("PartTime Employee Details");
            PartimeEmployee partimeEmployee = new PartimeEmployee();
            partimeEmployee.GetDetails();
            //partimeEmployee.GetPartimeEmployeeDetails();
            partimeEmployee.DisplayDetails();
            //partimeEmployee.DisplayPartimeEmployeeDetails();

        }
    }
}
