using Microsoft.VisualStudio.TestTools.UnitTesting;
using Presentation.ViewModel;

namespace MusicShopTests.Presentation;

[TestClass]
public class MainWindowViewModelTest
{
    private MainWindowViewModel _viewModel;

    [TestInitialize]
    public void TestInitialize()
    {
        _viewModel = new MainWindowViewModel();
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
        _viewModel.SwitchView("ProductListView");
        Assert.IsInstanceOfType(_viewModel.SelectedVm, typeof(ProductListViewModel));
    }
}