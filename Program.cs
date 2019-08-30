using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class Program
    {

        static void Main(string[] args)
        {
            EmployeeUtility.loadHomeScreen();
            List<Employee> employees = EmployeeUtility.loadEmployees();
            Console.WriteLine();
            Console.WriteLine("                                     Employee Management System");
            Console.WriteLine("                                     --------------------------");

            Console.WriteLine();
            Console.WriteLine();
            int choice;
            string tryMore = "Y";
            Console.WriteLine();

            while (tryMore.ToUpper() == "Y")
            {
                Console.WriteLine("                  1.Display Employee");
                Console.WriteLine("                  2.Search Employee By ID");
                Console.WriteLine("                  3.Edit Employee");
                Console.WriteLine("                  4.Add New Employe");
                Console.WriteLine("                  5.Delete Employee");
                Console.WriteLine("                  6.Exit");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("     Enter your choice:(1:6): ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        EmployeeCrud.displayEmployees(employees);

                        break;

                    case 2:
                        EmployeeCrud.findEmployeeById(employees);

                        break;
                    case 3:
                        EmployeeCrud.editEmployee(employees);

                        break;

                    case 4:
                        EmployeeCrud.addEmployee(employees);

                        break;
                    case 5:
                        EmployeeCrud.deleteEmployee(employees);
                        break;

                    case 6:
                        string dashBoard = "";
                        Console.WriteLine();
                        Console.WriteLine("Do you want to switch to EMPLOYEE DASHBOARD[Y/N]: ");
                        dashBoard = Console.ReadLine();
                        if (dashBoard.ToUpper() == "Y")
                        {
                            Console.Clear();
                            EmployeeAnalysis.analysisDashboardMenu();
                        }
                        Console.WriteLine("           PROGRAM TERMINATING,,,HIT [ENTER] TO END THE PROGRAM!!!!!!!!!");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid Choice,,Try Again!!!!");
                        break;
                }
                Console.WriteLine();
                Console.Write("Do you want to Continue(Y/N): ");
                tryMore = Console.ReadLine();
            }
            Console.WriteLine("           PROGRAM TERMINATING,,,hit any [KEY] TO END THE PROGRAM!!!!!!!!!");
            Console.ReadLine();
        }
    }
}

