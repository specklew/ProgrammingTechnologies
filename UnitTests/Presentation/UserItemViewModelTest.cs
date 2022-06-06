using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicShopTests.Presentation.Dummies;
using Presentation.ViewModel;

namespace MusicShopTests.Presentation;

[TestClass]
public class UserItemViewModelTest
{
    [TestMethod]
    public void UserConstructorTest()
    {
        var userItemViewModel = new UserItemViewModel(0, "name", 20, new UserModelDummy());

        Assert.AreEqual(0, userItemViewModel.Id);
        Assert.AreEqual("name", userItemViewModel.Name);
        Assert.AreEqual(20, userItemViewModel.Age);
    }

    [TestMethod]
    public void CheckIfCommandInitialized()
    {
        var userItemViewModel = new UserItemViewModel(0, "name", 20);

        var updateCommand = userItemViewModel.UpdateCommand;

        Assert.IsNotNull(updateCommand);
    }

    [TestMethod]
    public void UpdateCorrectness()
    {
        var userItemViewModel = new UserItemViewModel(0, "name", 20);

        var updateCommand = userItemViewModel.UpdateCommand;

        userItemViewModel.Name = null;
        userItemViewModel.Age = 0;

        bool test = userItemViewModel.CanUpdate;
        Assert.IsFalse(updateCommand.CanExecute(test));
    }
}