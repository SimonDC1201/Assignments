using System;
using System.Collections.Generic;

#nullable disable

namespace assignment02.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public long OrderId { get; set; }
        public long? CustomerId { get; set; }
        public long? EmployeeId { get; set; }
        public byte[] OrderDate { get; set; }
        public long? ShipperId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Shipper Shipper { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
