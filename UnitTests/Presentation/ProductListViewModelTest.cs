using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicShopTests.Presentation.Dummies;
using Presentation.ViewModel;

namespace MusicShopTests.Presentation;

[TestClass]
    public class ProductListViewModelTest
    {
        private ProductListViewModel _productListViewModel;

        [TestInitialize]
        public void TestInitialize()
        {
            _productListViewModel = new ProductListViewModel(new ProductModelDummy())
            {
                ProductViewModels = new ObservableCollection<ProductItemViewModel>
                {
                    new(0, "name1", "description1", 100),
                    new(1, "name2", "description2", 200),
                    new(2, "name3", "description3", 300),
                    new(3, "name4", "description4", 400)
                }
            };
        }


        [TestMethod]
        public void CheckIfNotNull()
        {
            Assert.IsNull(_productListViewModel.SelectedVm);
            Assert.IsNotNull(_productListViewModel.AddCommand);
            Assert.IsNotNull(_productListViewModel.DeleteCommand);
        }

        [TestMethod]
        public void CorrectNumberOfElements()
        {
            Assert.IsNotNull(_productListViewModel.ProductViewModels);
            Assert.AreEqual(_productListViewModel.ProductViewModels.Count, 4);
        }

        [TestMethod]
        public void DeleteCommandExecutionTest()
        {
            _productListViewModel.SelectedVm = null;
            var deleteCommand = _productListViewModel.DeleteCommand;
            var can = _productListViewModel.IsProductViewModelSelected;
            Assert.IsFalse(deleteCommand.CanExecute(can));
        }

        [TestMethod]
        public void AddCommandExecutionTest()
        {
            var addCommand = _productListViewModel.AddCommand;
            _productListViewModel.Name = "test";
            _productListViewModel.Description = "desc";
            _productListViewModel.Price = 100;
            var can = _productListViewModel.CanAdd;
            Assert.IsTrue(addCommand.CanExecute(can));
        }
    }