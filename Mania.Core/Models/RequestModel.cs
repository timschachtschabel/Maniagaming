using System;
using System.Collections.Generic;
using System.Text;

namespace Mania.Core.Models
{
    class RequestModel
    {
        public int RequestNumber { get; set; }
        //probably not needed
        public decimal Price { get; set; }
        public int AmountOfProducts { get; set; }
    }
}
