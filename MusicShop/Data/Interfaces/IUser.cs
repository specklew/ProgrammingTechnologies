using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.Data
{
    public interface IUser
    {
        string GUID { get; }
        string Name { get; set; }
        int Age { get; set; }
    }
}
