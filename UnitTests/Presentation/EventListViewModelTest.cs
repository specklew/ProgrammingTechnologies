using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicShopTests.Presentation.Dummies;
using Presentation.ViewModel;

namespace MusicShopTests.Presentation;

    [TestClass]
    public class EventListViewModelTest
    {
        private EventListViewModel _eventListViewModel;
        
        [TestInitialize]
        public void TestInitialize()
        {
            _eventListViewModel = new EventListViewModel(new EventModelDummy())
            {
                EventViewModels = new ObservableCollection<EventItemViewModel>
                {
                    new(0, 1, 2),
                    new(3, 4, 5),
                    new(6, 7, 8),
                    new(9, 10, 11)
                }
            };
        }

        [TestMethod]
        public void CheckIfNotNull()
        {
            Assert.IsNull(_eventListViewModel.SelectedVm);
            Assert.IsNotNull(_eventListViewModel.AddCommand);
            Assert.IsNotNull(_eventListViewModel.DeleteCommand);
        }

        [TestMethod]
        public void CorrectNumberOfElements()
        {
            Assert.IsNotNull(_eventListViewModel.EventViewModels);
            Assert.AreEqual(_eventListViewModel.EventViewModels.Count, 4);
        }

        [TestMethod]
        public void DeleteCommandExecutionTest()
        {
            _eventListViewModel.SelectedVm = null;
            var deleteCommand = _eventListViewModel.DeleteCommand;
            var can = _eventListViewModel.IsEventViewModelSelected;
            Assert.IsFalse(deleteCommand.CanExecute(can));
        }

        [TestMethod]
        public void AddCommandExecutionTest()
        {
            var addCommand = _eventListViewModel.AddCommand;
            _eventListViewModel.ProductId = 6;
            _eventListViewModel.UserId = 9;
            bool can = _eventListViewModel.CanAdd;
            Assert.IsTrue(addCommand.CanExecute(can));
        }
    }