using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Data
{
    internal class OrderEvent : Event
    {
        public IOrder Order { get; }

        public OrderEvent(IUser user, IOrder order, OrderStatus status, IState state) : base(user, state)
        {
            Order = order;
            order.Status = status;
        }
    }
}
