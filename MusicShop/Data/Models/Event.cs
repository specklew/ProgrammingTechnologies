using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Data
{
    internal abstract class Event
    {
        public IUser User { get; }
        public IState ShopState { get; }
        public DateTime EventTime { get; }

        protected Event(IUser user, IState state)
        {
            User = user;
            ShopState = state;
            EventTime = DateTime.Now;
        }
    }
}
