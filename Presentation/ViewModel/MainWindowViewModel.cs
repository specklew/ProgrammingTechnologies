using Presentation.ViewModel.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Presentation.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _SelectedVM;
        private ICommand _SwitchViewCommand;

        public MainWindowViewModel()
        {
            SelectedVM = new UserListViewModel();
            _SwitchViewCommand = new RelayCommand(view => { SwitchView(view.ToString()); });
        }

        public ViewModelBase SelectedVM
        {
            get => _SelectedVM;
            set
            {
                _SelectedVM = value;
                OnPropertyChanged(nameof(SelectedVM));
            }
        }

        public ICommand SwitchViewCommand
        {
            get => _SwitchViewCommand;
        }

        public void SwitchView(string view)
        {
            switch (view)
            {
                case "UserListView":
                    SelectedVM = new UserListViewModel();
                    break;
                case "ProductListView":
                    //SelectedVM = new ProductListViewModel();
                    break;
                case "EventListView":
                    //SelectedVM = new EventListViewModel();
                    break;
            }
        }
    }
}
