using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2Demo
{

    class EmployeeComparerName : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            Employee empX = (Employee)x;
            Employee empY = (Employee)y;

            return empX.Name.CompareTo(empY.Name);
        }
    }


    internal class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public double Salary { get; set; }

        public int CompareTo(Employee? other)
        {
            Employee E =(Employee) other;
            return this.Age.CompareTo(other.Age);
        }

        public override string ToString()
        {
            return $"Id:{Id} , Name : {Name} , Age :{Age} , Salary : {Salary} ";
        }
    }
}
