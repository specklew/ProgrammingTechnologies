using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicShopTests.Presentation.Dummies;
using Presentation.ViewModel;

namespace MusicShopTests.Presentation;

[TestClass]
public class MainWindowViewModelTest
{
    private MainWindowViewModel _viewModel;

    [TestInitialize]
    public void TestInitialize()
    {
        _viewModel = new MainWindowViewModel(new UserListViewModel(new UserModelDummy()));
    }

    [TestMethod]
    public void GetDefaultViewCorrectly()
    {
        Assert.IsInstanceOfType(_viewModel.SelectedVm, typeof(UserListViewModel));
    }
    
    [TestMethod]
    public void SetViewCorrectly()
    {
        Assert.IsInstanceOfType(_viewModel.SelectedVm, typeof(UserListViewModel));
        _viewModel.SelectedVm = new ProductListViewModel(new ProductModelDummy());
        Assert.IsInstanceOfType(_viewModel.SelectedVm, typeof(ProductListViewModel));
    }
}