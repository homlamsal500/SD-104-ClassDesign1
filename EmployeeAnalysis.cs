using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class EmployeeAnalysis
    {
        static List<Employee> emps = EmployeeUtility.loadEmployees();
        public static void analysisDashboardMenu()
        {
            Console.WriteLine();
            Console.WriteLine("     Employee Dashboard ");
            Console.WriteLine("----------------------------- ");
            Console.WriteLine();
            Console.WriteLine();
            int choice;
            string tryMore = "Y";
            Console.WriteLine();
            while (tryMore.ToUpper() == "Y")
            {
                Console.WriteLine("                  1.Male/Female Propertion");
                Console.WriteLine("                  2.No of Married Employee");
                Console.WriteLine("                  3.Most youngest Employee");
                Console.WriteLine("                  4.Married/Unmarried Propertion");
                Console.WriteLine("                  5.Exit");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("     Enter your choice:(1:5): ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        maleFemaleRatio();
                        break;

                    case 2:

                        break;
                    case 3:
                        yongestEmployee();

                        break;

                    case 4:

                        break;
                    case 5:

                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Do you want more[Y/N]: ");
                tryMore = Console.ReadLine();

            }
        }

        private static void yongestEmployee()
        {
            foreach (Employee e in emps)
            {
                Console.WriteLine(EmployeeUtility.CalculateAge(e.Dob));
            }
        }

        private static void maleFemaleRatio()
        {
            int maleCount = 0;
            int femaleCount = 0;
            foreach (Employee e in emps)
            {
                if (e.Gender.ToUpper() == "MALE")
                {
                    maleCount++;
                }
                else
                {
                    femaleCount++;
                }
            }

            Console.WriteLine();
            Console.Write("Male Employee: " + maleCount);
            Console.Write("Female Employee: " + femaleCount);
            Console.WriteLine();
            Console.WriteLine("Male:Female Ratio: " + maleCount + ":" + femaleCount);
        }
    }
}

