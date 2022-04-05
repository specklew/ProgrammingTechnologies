using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Data
{
    internal class OrderEvent : Event
    {
        public int OrderID { get; }
        public OrderStatus Status { get; }

        public OrderEvent(IUser user, int orderId, OrderStatus orderStatus) : base(user)
        {
            OrderID = orderId;
            Status = orderStatus;
        }
    }
}
