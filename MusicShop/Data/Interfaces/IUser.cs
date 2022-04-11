namespace MusicShop.Data
{
    public interface IUser
    {
        string GUID { get; }
        string Name { get; set; }
        int Age { get; set; }
    }
}
