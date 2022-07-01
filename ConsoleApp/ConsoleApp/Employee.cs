using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Employee : IEmployeInterface
    {
        public string EmployeeAddress()
        {
            return "Employee Name : Nagarjuna";
        }

        public string EmployeeCity()
        {
            throw new NotImplementedException();
        }

        public string EmployeeDetails()
        {
            return "Employee Address : Tirupathi";
        }
    }
}
