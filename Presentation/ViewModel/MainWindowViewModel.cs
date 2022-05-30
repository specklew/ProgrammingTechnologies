using Presentation.ViewModel.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Presentation.ViewModel;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase _SelectedVm;
    private ICommand _SwitchViewCommand;

    public MainWindowViewModel()
    {
        SelectedVm = new UserListViewModel();
        _SwitchViewCommand = new RelayCommand(view => { SwitchView(view.ToString()); });
    }

    public ViewModelBase SelectedVm
    {
        get => _SelectedVm;
        set
        {
            _SelectedVm = value;
            OnPropertyChanged(nameof(SelectedVm));
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
                SelectedVm = new UserListViewModel();
                break;
            case "ProductListView":
                //SelectedVm = new ProductListViewModel();
                break;
            case "EventListView":
                //SelectedVm = new EventListViewModel();
                break;
        }
    }
}