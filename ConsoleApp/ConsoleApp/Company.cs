using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Company
    {
        public string GetEmployeeDetails()
        {
            IEmployeInterface employe = new Employee();
            return employe.EmployeeDetails() + employe.EmployeeAddress();
        }
    }
}
