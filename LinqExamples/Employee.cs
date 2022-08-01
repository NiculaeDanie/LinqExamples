using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    public class Employee
    {
        public int ID { get; set; }
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public Employee(int iD, int departmentID, string name)
        {
            ID = iD;
            DepartmentID = departmentID;
            Name = name;
        }

        public Employee()
        {
        }
    }
}
