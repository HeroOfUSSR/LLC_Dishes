using System;
using System.Collections.Generic;

namespace LLC._Dishes
{
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            Dishes = new HashSet<Dish>();
        }

        public int IdManufacturer { get; set; }
        public string NameManufacturer { get; set; } = null!;

        public virtual ICollection<Dish> Dishes { get; set; }
    }
}
