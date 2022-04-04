using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Data
{
    public class Order
    {
        public int Id { get; }
        private OrderStatus status;
        private List<ProductLine> products;

        public Order(int id, IEnumerable<ProductLine> productLines)
        {
            this.Id = id;
            this.status = OrderStatus.Pending;
            this.products = new List<ProductLine>(productLines);
        }

        public void CancelOrder()
        {
            this.status = OrderStatus.Cancelled;
        }

        public void CompleteOrder()
        {
            this.status = OrderStatus.Completed;
        }
    }
}
