using System;

namespace MusicShop.Data;

public abstract class Event
{
    public string Guid { get; }
    public IUser User { get; }
    public IState ShopState { get; }
    public DateTime EventTime { get; }

    protected Event(IUser user, IState state)
    {
        Guid = System.Guid.NewGuid().ToString();
        User = user;
        ShopState = state;
        EventTime = DateTime.Now;
    }
}