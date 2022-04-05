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
        public DateTime EventTime { get; }

        protected Event(IUser user)
        {
            User = user;
            EventTime = DateTime.Now;
        }
    }
}
