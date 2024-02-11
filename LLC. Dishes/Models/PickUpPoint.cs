using System;
using System.Collections.Generic;

namespace LLC._Dishes
{
    public partial class PickUpPoint
    {
        public PickUpPoint()
        {
            Orders = new HashSet<Order>();
        }

        public int PickUpId { get; set; }
        public int Postcode { get; set; }
        public string CityName { get; set; } = null!;
        public string StreetName { get; set; } = null!;
        public int HouseNumber { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
