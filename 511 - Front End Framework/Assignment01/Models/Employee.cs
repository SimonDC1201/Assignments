using System;
using System.Collections.Generic;

#nullable disable

namespace Assignment01.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Orders = new HashSet<Order>();
        }

        public long EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public byte[] BirthDate { get; set; }
        public string Photo { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
