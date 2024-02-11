using System;
using System.Collections.Generic;

namespace LLC._Dishes
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public string OrderList { get; set; } = null!;
        public int AmountOrder { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderDoneDate { get; set; }
        public int IdPickUp { get; set; }
        public string? ClientFio { get; set; }
        public int PickUpCode { get; set; }
        public int OrderStatus { get; set; }

        public virtual PickUpPoint IdPickUpNavigation { get; set; } = null!;
        public virtual Dish OrderListNavigation { get; set; } = null!;
    }
}
