using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Core.Data
{
    public class Order : BaseEntity
    {
        public byte Quantity { get; set; }
        public Decimal Price { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
    }  
}
