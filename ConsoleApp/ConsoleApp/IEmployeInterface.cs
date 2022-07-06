using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public interface IEmployeInterface
    {
        public string EmployeeDetails();
        public string EmployeeDetails(string employeeName);
        public string EmployeeDetails(string employeeName, string employeeId);
        public string EmployeeDetails(int employeeId, string employeeName);
        public string EmployeeAddress();
        public string EmployeeCity();
        public string EmployeeRegion();
    }
}
