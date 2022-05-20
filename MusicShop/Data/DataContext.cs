using System.Collections.Generic;

namespace MusicShop.Data;

internal class DataContext
{
    public readonly ProductCatalog Catalog = new();
    public readonly List<IUser> Users = new();
    public readonly List<IState> States = new();
    public readonly List<Event> Events = new();
}