using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Presentation.ViewModel;

namespace MusicShopTests.Presentation;

[TestClass]
public class UserListViewModelTest
{
    private UserListViewModel _userListVm;

    [TestInitialize]
    public void TestInitialize()
    {
        var userViewModels = new UserListViewModel
        {
            UserViewModels = new ObservableCollection<UserItemViewModel>
            {
                new(1, "testName", 20),
                new(2, "testName2", 30),
                new(3, "testName3", 40),
                new(4, "testName4", 50)
            }
        };

        _userListVm = userViewModels;
    }


    [TestMethod]
    public void CheckIfNotNull()
    {
        Assert.IsNull(_userListVm.SelectedVm);
        Assert.IsNotNull(_userListVm.AddCommand);
        Assert.IsNotNull(_userListVm.DeleteCommand);
    }

    [TestMethod]
    public void CorrectNumberOfElements()
    {
        Assert.IsNotNull(_userListVm.UserViewModels);
        Assert.AreEqual(_userListVm.UserViewModels.Count, 4);
    }

    [TestMethod]
    public void DeleteCommandExecutionTest()
    {
        _userListVm.SelectedVm = null;
        var deleteCommand = _userListVm.DeleteCommand;
        var test = _userListVm.IsUserViewModelSelected;
        Assert.IsFalse(deleteCommand.CanExecute(test));
    }

    [TestMethod]
    public void AddCommandExecutionTest()
    {
        var addCommand = _userListVm.AddCommand;
        _userListVm.Name = "test";
        _userListVm.Age = 10;
        var can = _userListVm.CanAdd;
        Assert.IsTrue(addCommand.CanExecute(can));
    }
}