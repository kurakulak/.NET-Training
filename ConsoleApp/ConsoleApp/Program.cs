using ConsoleApp;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company employeeDetails = new Company();
            string empDetails = employeeDetails.GetEmployeeDetails();
            Console.WriteLine(empDetails);
            Console.WriteLine("Hello World!");
        }
    }
}