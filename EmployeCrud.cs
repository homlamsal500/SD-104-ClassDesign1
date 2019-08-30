using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class EmployeeCrud
    {
        private static void companyInfo()
        {
            Console.WriteLine();
            Console.WriteLine("              XYZ Corporation             ");
            Console.WriteLine("      3819 Regent Blvd,Coppell,TX             ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
        }
        public static void displayEmployees(List<Employee> employees)
        {
            companyInfo();
            foreach (Employee e in employees)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------");
            }
        }

        public static void findEmployeeById(List<Employee> employees)
        {
            Console.WriteLine();
            Console.Write("Give employee id to search: ");
            string eid = Console.ReadLine();
            int found = 0;
            foreach (Employee e in employees)
            {
                if (e.Id == eid)
                {
                    found++;
                }
            }
            if (found > 0)
            {
                Console.WriteLine("Employee with id: " + eid + " has been found!!");
            }
            else
            {
                Console.WriteLine("Employee with id: " + eid + " doesn't exist in employee record.");
            }
        }

        public static void editEmployee(List<Employee> employees)
        {
            Console.WriteLine();
            Console.Write("Give employee id to Edit: ");
            string eid = Console.ReadLine();
            int found = 0;
            foreach (Employee e in employees)
            {
                if (e.Id == eid)
                {
                    found++;
                    Console.WriteLine("Enter new ID: ");
                    e.Id = Console.ReadLine();
                    Console.WriteLine("Enter new Name: ");
                    e.Ename = Console.ReadLine();
                }
            }
            if (found < 1)
            {
                Console.WriteLine("Employee with id: " + eid + " doesn't exist in employee record.");
            }
        }
        public static void addEmployee(List<Employee> employees)
        {
            Employee temp = new Employee();
            Console.WriteLine("Enter employee id: ");
            temp.Id = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter employee Name: ");
            temp.Ename = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter employee Post: ");
            temp.Post = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter employee salary: ");
            temp.Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter employee DOB: ");
            temp.Dob = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter employee job Status: ");
            temp.EmpStatus = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("isMarried?: ");
            temp.IsMarried = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter Employee Gender: ");
            temp.Gender = Console.ReadLine();
            Console.WriteLine();

            employees.Add(temp);
            Console.WriteLine();
            Console.WriteLine("Employee " + temp.Ename + "  has been successfully saved to employee record");

        }
        public static void deleteEmployee(List<Employee> employees)
        {
            Console.WriteLine();
            Console.WriteLine("Give employee id to delete: ");
            string eid = Console.ReadLine();
            int found = 0;
            foreach (Employee e in employees)
            {
                if (e.Id == eid)
                {
                    found++;
                    employees.Remove(e);
                    Console.WriteLine("Employee with id: " + eid + " has been successfully removed from employee record");
                    break;
                }
            }
            if (found < 1)
            {
                Console.WriteLine("Employee with id: " + eid + " doesn't exist in employee record.");
            }
        }
    }
}
