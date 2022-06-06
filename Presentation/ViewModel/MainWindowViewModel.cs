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
    private ViewModelBase _selectedVm;
    private ICommand _SwitchViewCommand;

    public MainWindowViewModel(UserListViewModel selectedVm = default(UserListViewModel))
    {
        SelectedVm = selectedVm ?? new UserListViewModel();
        _SwitchViewCommand = new RelayCommand(view => { SwitchView(view.ToString()); });
    }

    public ViewModelBase SelectedVm
    {
        get => _selectedVm;
        set
        {
            _selectedVm = value;
            OnPropertyChanged(nameof(SelectedVm));
        }
    }

    public ICommand SwitchViewCommand => _SwitchViewCommand;

    public void SwitchView(string view)
    {
        switch (view)
        {
            case "UserListView":
                SelectedVm = new UserListViewModel();
                break;
            case "ProductListView":
                SelectedVm = new ProductListViewModel();
                break;
            case "EventListView":
                SelectedVm = new EventListViewModel();
                break;
        }
    }
}