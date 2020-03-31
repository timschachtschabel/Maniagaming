using System;
using System.Collections.Generic;
using System.Text;

namespace Mania.Core.Models
{
    class OrderModel
    {
        public int OrderNumber { get; set; }
        public decimal Price { get; set; }
        public List<ProductModel> Producten { get; set; }
    }
}
