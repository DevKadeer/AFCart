using System;
using System.Collections.Generic;

namespace AFCart.Models
{
    public partial class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CategoryId { get; set; }
        public int? SubCategoryId { get; set; }

        public Categories Category { get; set; }
        public SubCategories SubCategory { get; set; }
    }
}
