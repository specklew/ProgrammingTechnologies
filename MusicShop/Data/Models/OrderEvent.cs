using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Data
{
    internal class OrderEvent : Event
    {
        public ProductLine OrderedProduct { get; }
        public OrderStatus Status { get; set; }

        public OrderEvent(IUser user, ProductLine line, State state) : base(user, state)
        {
            OrderedProduct = line;
            Status = OrderStatus.Pending;
        }
    }
}
