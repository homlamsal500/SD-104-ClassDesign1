using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class Employee
    {
        private string id;
        private string ename;
        private string post;
        private double salary;
        private DateTime dob;
        private string empStatus;
        private bool isMarried;
        private string gender;


        public Employee() { }

        public Employee(string id, string ename, string post, double salary, DateTime dob, string empStatus, bool isMarried, string gender)
        {
            this.id = id;
            this.ename = ename;
            this.post = post;
            this.salary = salary;
            this.dob = dob;
            this.empStatus = empStatus;
            this.isMarried = isMarried;
            this.gender = gender;
        }

        public string Id { get => id; set => id = value; }
        public string Ename { get => ename; set => ename = value; }
        public string Post { get => post; set => post = value; }
        public double Salary { get => salary; set => salary = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string EmpStatus { get => empStatus; set => empStatus = value; }
        public bool IsMarried { get => isMarried; set => isMarried = value; }
        public string Gender { get => gender; set => gender = value; }

        public override string ToString()
        {

            // String.Format("{0}\t{1}", FirstName, Count);

            // return id+"\t"+"      "+ename + "         " + post + "        " + salary+"         "+empStatus + "       " +isMarried+"        "+ gender;

            return string.Format("{0}{1,25}{2,30}{3,33}", id, ename, post, salary);
        }
    }

}
