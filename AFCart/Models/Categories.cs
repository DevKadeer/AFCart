using System;
using System.Collections.Generic;

namespace AFCart.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Products = new HashSet<Products>();
            SubCategories = new HashSet<SubCategories>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Products> Products { get; set; }
        public ICollection<SubCategories> SubCategories { get; set; }
    }
}
