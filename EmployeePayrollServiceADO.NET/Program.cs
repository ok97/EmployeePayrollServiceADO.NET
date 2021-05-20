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
            EmployeeRepository repository = new EmployeeRepository();//Creating a object of EmployeeRepository class.
           

           // repository.DataBaseConnection(); // UC1 Ensuring the database connection using the sql connection string
           

            repository.GetAllEmployeeData(); //UC2
           
            //AddRecordInput();//UC2 add Record

            Console.ReadLine();
        }
        public static void AddRecordInput()
        {
            EmployeeRepository repository = new EmployeeRepository();//Creating a object of EmployeeRepository class.
            EmployeeModel model = new EmployeeModel();// Adding Employee To Database
            DateTime now = DateTime.Now;
            model.EmployeeId = 1;
            model.EmployeeName = "Omprakash";
            model.PhoneNumber = "8788616249";
            model.Address = "Ward No.01";
            model.Department = "HR";
            model.Gender = "M";
            model.BasicPay = 50000;
            model.Deductions = 1000;
            model.TaxablePay = 1800;
            model.Tax = 800;
            model.NetPay = 200;
            model.StartDate = now;
            model.City = "Pune";
            model.Country = "IN";

            Console.WriteLine(repository.AddEmployee(model) ? "Record Successfully Inserted On Table" : "Failed"); //Conditional (Ternary) operator
           // repository.GetAllEmployeeData(); //call method to show table record
        }
    }
}
