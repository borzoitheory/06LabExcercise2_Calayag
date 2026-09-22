using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNameSpace
{
    class Employee
    {
        private string employeeID;
        private string employeeFirstName;
        private string employeeLastName;
        private string employeePosition;

        public string EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string EmployeeFirstName
        {
            get { return employeeFirstName; }
            set { employeeFirstName = value; }
        }

        public string EmployeeLastName
        {
            get { return employeeLastName; }
            set { employeeLastName = value; }
        }

        public string EmployeePosition
        {
            get { return employeePosition; }
            set { employeePosition = value; }
        }

        public Employee()
        {
            this.employeeID = string.Empty;
            this.employeeFirstName = string.Empty;
            this.employeeLastName = string.Empty;
            this.employeePosition = string.Empty;
        }

        public Employee(string id, string empFirstName, string empLastName, string empPosition)
        {
            this.employeeID = id;
            this.employeeFirstName = empFirstName;
            this.employeeLastName = empLastName;
            this.employeePosition = empPosition;
        }
    }
}
