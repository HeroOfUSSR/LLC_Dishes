using System;
using System.Collections.Generic;

namespace LLC._Dishes
{
    public partial class Supplier
    {
        public Supplier()
        {
            Dishes = new HashSet<Dish>();
        }

        public int SupplierId { get; set; }
        public string? SupplierName { get; set; }

        public virtual ICollection<Dish> Dishes { get; set; }
    }
}
