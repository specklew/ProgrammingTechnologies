using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Presentation.ViewModel;

namespace MusicShopTests.Presentation;

[TestClass]
public class EventItemViewModelTest
{
    [TestMethod]
    public void EventConstructorTest()
    {
        var time = DateTime.Now;

        var eventItemViewModel = new EventItemViewModel(0, 1, 2, time);

        Assert.AreEqual(0, eventItemViewModel.Id);
        Assert.AreEqual(1, eventItemViewModel.UserId);
        Assert.AreEqual(2, eventItemViewModel.ProductId);
        Assert.AreEqual(time, eventItemViewModel.EventTime);
    }
}