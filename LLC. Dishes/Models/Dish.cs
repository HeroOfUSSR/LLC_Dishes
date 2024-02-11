using System;
using System.Collections.Generic;

namespace LLC._Dishes
{
    public partial class Dish
    {
        public Dish()
        {
            Orders = new HashSet<Order>();
        }

        public string Article { get; set; } = null!;
        public string DishName { get; set; } = null!;
        public string Unit { get; set; } = null!;
        public int Cost { get; set; }
        public double MaxDiscount { get; set; }
        public int ManufacturerId { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public double? ActiveDiscount { get; set; }
        public int Amount { get; set; }
        public string? Description { get; set; }
        public byte[]? Image { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual Manufacturer Manufacturer { get; set; } = null!;
        public virtual Supplier Supplier { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
    }
}
