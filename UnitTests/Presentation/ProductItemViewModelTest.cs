using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicShopTests.Presentation.Dummies;
using Presentation.ViewModel;

namespace MusicShopTests.Presentation;

[TestClass]
public class ProductItemViewModelTest
{
    [TestMethod]
    public void ProductConstructorTest()
    {
        var productItemViewModel = new ProductItemViewModel(0, "test", "description", 2137, new ProductModelDummy());

        Assert.AreEqual(0, productItemViewModel.Id);
        Assert.AreEqual("test", productItemViewModel.Name);
        Assert.AreEqual("description", productItemViewModel.Description);
        Assert.AreEqual(2137, productItemViewModel.Price);
    }

    [TestMethod]
    public void CheckIfCommandInitialized()
    {
        var productItemViewModel = new ProductItemViewModel(0, "test", "description", 2137);
        var updateCommand = productItemViewModel.UpdateCommand;
        Assert.IsNotNull(updateCommand);
    }

    [TestMethod]
    public void UpdateCorrectness()
    {
        var productItemViewModel = new ProductItemViewModel(0, "test", "description", 2137);
        var updateCommand = productItemViewModel.UpdateCommand;
        productItemViewModel.Name = null;
        var canBeExecuted = productItemViewModel.CanUpdate;
        Assert.IsFalse(updateCommand.CanExecute(canBeExecuted));
    }
}