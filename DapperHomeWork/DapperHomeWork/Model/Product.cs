using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperHomeWork.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductPrice { get; set; }
    }
}
