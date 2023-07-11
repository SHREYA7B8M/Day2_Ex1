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
            Console.WriteLine("Employee Gender: ");
            EmployeeGender=char.Parse(Console.ReadLine());  
            Console.WriteLine("DOJ: ");
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
            Console.WriteLine("ID: \t" + id + "\n Employee Name: " + EmployeeName + "\n Employee Gender: \t" + EmployeeGender +
                "\n  Employee Salary: \t" + EmployeeSalary + "\nDOJ: \t" + DOJ);
            Console.ReadLine(); 

        }
    }
}
