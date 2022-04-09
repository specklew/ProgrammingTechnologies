using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Data
{
    public abstract class Event
    {
        public string GUID { get; }
        public IUser User { get; }
        public IState ShopState { get; }
        public DateTime EventTime { get; }

        protected Event(IUser user, IState state)
        {
            GUID = Guid.NewGuid().ToString();
            User = user;
            ShopState = state;
            EventTime = DateTime.Now;
        }
    }
}
