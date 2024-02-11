using System;
using System.Collections.Generic;

namespace LLC._Dishes
{
    public partial class Category
    {
        public Category()
        {
            Dishes = new HashSet<Dish>();
        }

        public int IdCategory { get; set; }
        public string NameCategory { get; set; } = null!;

        public virtual ICollection<Dish> Dishes { get; set; }
    }
}
