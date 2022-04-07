using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Data
{
    internal class OrderEvent : Event
    {
        public Order Order { get; }

        public OrderEvent(IUser user, Order order, OrderStatus status, State state) : base(user, state)
        {
            Order = order;
            order.Status = status;
        }
    }
}
