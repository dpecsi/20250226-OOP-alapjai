using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250226_MyClasses
{
    public class Employee : User
    {
        private static int _employeeCount = 0;
        public int EmployeeId
        {
            get; set;
        } = 0;

        public string PhoneNumber
        {
            get; set;
        } = string.Empty;

        public Employee(string name)
            : base(name)
        {
            this.setId();
        }

        public Employee(string name, string email)
            : base(name, email)
        {
            this.setId();
        }

        private void setId()
        {
            Employee._employeeCount++;
            this.EmployeeId = Employee._employeeCount;
        }

        public Employee(string name, string email, string phoneNumber)
            : this(name, email)
        {
            this.PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"Alkamazott ({this.EmployeeId}): " + base.ToString();
        }
    }
}
