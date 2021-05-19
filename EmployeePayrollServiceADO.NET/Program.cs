using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollServiceADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll Services Using ADO.NET Problem");

            EmployeeRepository emprepository = new EmployeeRepository();  //Creating a object of EmployeeRepository class.

            //emprepository.DataBaseConnection(); // UC1 Ensuring the database connection using the sql connection string
            emprepository.GetAllRecord();
            Console.ReadLine();
        }
    }
}
