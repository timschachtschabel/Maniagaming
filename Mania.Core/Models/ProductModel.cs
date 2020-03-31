using System;
using System.Collections.Generic;
using System.Text;

namespace Mania.Core.Models
{
    class ProductModel
    {
        public string Name  { get; set; }
        public decimal Price { get; set; }
        public CategoryModel Category { get; set; }
        public PlatformModel Platform { get; set; }
        public string Description { get; set; }
        public ConditionModel Condition { get; set; }
        public bool IsSecondHand { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
