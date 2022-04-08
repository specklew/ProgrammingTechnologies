using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Data
{
    internal class Order : IOrder
    {
        public string GUID { get; }
        public OrderStatus Status { get; set; }
        private List<ProductLine> products;

        public Order(IEnumerable<ProductLine> productLines)
        {
            GUID = Guid.NewGuid().ToString();
            Status = OrderStatus.Pending;
            products = new List<ProductLine>(productLines);
        }
    }
}
