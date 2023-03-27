using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task3.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
       
        public int UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public int unitsOnOrder { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
