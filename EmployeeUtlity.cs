using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class EmployeeUtility
    {
        public static void loadHomeScreen()
        {
            Console.WriteLine();
            Console.WriteLine("                                                --------------------------------------------------------");
            Console.WriteLine("                                                |                                                        |");
            Console.WriteLine("                                                |                     HIMALAYAN CORPORATION              |");
            Console.WriteLine("                                                |            We are Committed for Customer Satisfaction  |");
            Console.WriteLine("                                                |                                                        |");
            Console.WriteLine("                                                |            3819 N Beltline Rd, Coppell,TX              |");
            Console.WriteLine("                                                ---------------------------------------------------------");
        }
        public static List<Employee> loadEmployees()
        {
            List<Employee> employeeList = new List<Employee>();

            Employee e1 = new Employee("e001", "Anil", "Chief Software Architect", 250000, DateTime.Parse("10/22/1985"), "FullTime", true, "Male");
            Employee e2 = new Employee("e002", "Kripa", "Phd Scholars", 150000, DateTime.Parse("11/22/1988"), "PartTime", true, "Female");
            Employee e3 = new Employee("e003", "Krishna", "Data Scientist", 165000, DateTime.Parse("10/21/1987"), "Fulltime", true, "Male");
            Employee e4 = new Employee("e004", "Rajesh", "Motivational Speaker", 155000, DateTime.Parse("01/22/1988"), "Fulltime", true, "Male");
            Employee e5 = new Employee("e005", "Hom", "Head of Media Council", 190000, DateTime.Parse("10/22/1983"), "Fulltime", true, "Male");
            Employee e6 = new Employee("e006", "Nancy", "Accountant", 85000, DateTime.Parse("10/22/1987"), "PartTime", false, "Female");
            Employee e7 = new Employee("e007", "Shakib", "Scrum Master", 105000, DateTime.Parse("10/22/1980"), "Fulltime", true, "Male");
            Employee e8 = new Employee("e008", "David", "Operation Manager", 95500, DateTime.Parse("10/22/1993"), "Fulltime", true, "Male");
            Employee e9 = new Employee("e009", "Ryan", "Junior Data Analyst", 75000, DateTime.Parse("10/22/1987"), "PartTime", true, "Male");
            Employee e10 = new Employee("e010", "Megan", "Cloud Engineer", 120000, DateTime.Parse("10/22/1990"), "PartTime", false, "Female");

            employeeList.Add(e1);
            employeeList.Add(e2);
            employeeList.Add(e3);
            employeeList.Add(e4);
            employeeList.Add(e5);
            employeeList.Add(e6);
            employeeList.Add(e7);
            employeeList.Add(e8);
            employeeList.Add(e9);
            employeeList.Add(e10);

            return employeeList;
        }
        public static string CalculateYourAge(DateTime Dob)
        {
            DateTime Now = DateTime.Now;
            int Years = new DateTime(DateTime.Now.Subtract(Dob).Ticks).Year - 1;
            DateTime PastYearDate = Dob.AddYears(Years);
            int Months = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (PastYearDate.AddMonths(i) == Now)
                {
                    Months = i;
                    break;
                }
                else if (PastYearDate.AddMonths(i) >= Now)
                {
                    Months = i - 1;
                    break;
                }
            }
            int Days = Now.Subtract(PastYearDate.AddMonths(Months)).Days;
            int Hours = Now.Subtract(PastYearDate).Hours;
            int Minutes = Now.Subtract(PastYearDate).Minutes;
            int Seconds = Now.Subtract(PastYearDate).Seconds;
            return String.Format("Age: {0} Year(s) {1} Month(s) {2} Day(s) {3} Hour(s) {4} Second(s)",
            Years, Months, Days, Hours, Seconds);
        }
        public static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;
            return age;
        }
    }
}
