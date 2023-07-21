using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day2_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            string EmployeeName;
            char EmployeeGender;
            double EmployeeSalary;
            DateTime DOJ;
            Console.WriteLine("Id: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Employee Name: ");
            EmployeeName = Console.ReadLine();
            Console.WriteLine("Employee Gender (M/F/Other): ");
            EmployeeGender=char.Parse(Console.ReadLine());  
            Console.WriteLine("DOJ (DD/MM/yyyy): ");
            DOJ= DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Employee Salary: ");
            EmployeeSalary=double.Parse(Console.ReadLine());
            if (EmployeeSalary > 900000)
            {
                Console.WriteLine("You will have to pay 30% tax");
            }
            else
            {
                Console.WriteLine("You will have to pay 15% tax");
            }
            Console.WriteLine("ID: \t" + id + "\nEmployee Name: " + EmployeeName + "\nEmployee Gender: \t" + EmployeeGender +
                "\nEmployee Salary: \t" + EmployeeSalary + "\nDOJ: \t" + DOJ);
            Console.ReadLine(); 

        }
    }
}
