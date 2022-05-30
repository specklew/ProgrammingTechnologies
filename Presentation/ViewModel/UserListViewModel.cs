using Presentation.ViewModel.MVVM;
using Services.API;
using Services.Data;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Presentation.ViewModel;

public class UserListViewModel : ViewModelBase  
{
    private int _id;
    private string _name;
    private int _age;

    private readonly IUserService _service;
    private ObservableCollection<UserItemViewModel> _userViewModels;
    private UserItemViewModel _selectedViewModel;
    private bool _isUserViewModelSelected;
    
    private Visibility _isUserViewModelSelectedVisibility;
    
    public UserListViewModel()
    {
        _service = new UserService();
        _userViewModels = new ObservableCollection<UserItemViewModel>();

        AddCommand = new RelayCommand(e => { AddUser(); },  _ => CanAdd);

        DeleteCommand = new RelayCommand(e => { DeleteUser(); }, _ => UserViewModelIsSelected());

        IsUserViewModelSelected = false;

        GetUsers();
    }


    public ICommand AddCommand { get; }
    public ICommand DeleteCommand { get; }

    private void AddUser()
    {
        _service.AddUser(_id, _name, _age);
        GetUsers();
    }

    private void DeleteUser()
    {
        _service.DeleteUser(SelectedVm.Id);

        GetUsers();
        OnPropertyChanged(nameof(UserViewModels));
    }

    private void GetUsers()
    {
        _userViewModels.Clear();

        foreach (var c in _service.GetAllUsers())
        {
            _userViewModels.Add(new UserItemViewModel(c.Id, c.Name, c.Age));
        }

        OnPropertyChanged(nameof(UserViewModels));
    }

    private bool UserViewModelIsSelected()
    {
        return _selectedViewModel is not null;
    }

    public int Id
    {
        get => _id;
        set
        {
            _id = value;

            OnPropertyChanged(nameof(Id));
        }
    }

    public string Name
    {
        get => _name;
        set
        {
            _name = value;

            OnPropertyChanged(nameof(Name));
        }
    }

    public int Age
    {
        get => _age;
        set
        {
            _age = value;

            OnPropertyChanged(nameof(Age));
        }
    }

    public bool IsUserViewModelSelected
    {
        get => _isUserViewModelSelected;
        set
        {
            IsUserViewModelSelectedVisibility = value ? Visibility.Visible : Visibility.Hidden;
            _isUserViewModelSelected = value;
            OnPropertyChanged(nameof(IsUserViewModelSelected));
        }
    }

    public Visibility IsUserViewModelSelectedVisibility
    {
        get => _isUserViewModelSelectedVisibility;
        set
        {
            _isUserViewModelSelectedVisibility = value;
            OnPropertyChanged(nameof(IsUserViewModelSelectedVisibility));
        }
    }

    public ObservableCollection<UserItemViewModel> UserViewModels
    {
        get => _userViewModels;

        set
        {
            _userViewModels = value;
            OnPropertyChanged(nameof(UserViewModels));
        }
    }

    public UserItemViewModel SelectedVm
    {
        get => _selectedViewModel;
        set
        {
            _selectedViewModel = value;
            IsUserViewModelSelected = true;
            OnPropertyChanged(nameof(SelectedVm));
        }
    }

    public bool CanAdd => !(string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Age.ToString()) || string.IsNullOrEmpty(Id.ToString()));
}