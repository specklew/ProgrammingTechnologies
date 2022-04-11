namespace MusicShop.Data
{
    internal class DataContext
    {
        public ProductCatalog Catalog = new();
        public List<IUser> Users = new();
        public List<IState> States = new();
        public List<Event> Events = new();
    }
}
