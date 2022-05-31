using Presentation.ViewModel.MVVM;
using System.Windows.Input;
using Presentation.Model;
using Presentation.Model.API;

namespace Presentation.ViewModel;

public class UserItemViewModel : ViewModelBase
{
    private int _id;
    private string _name;
    private int _age;

    private readonly IUserModel _model;

    public UserItemViewModel(int id = 0, string firstName = null, int age = 0)
    {
        _id = id;
        _name = firstName;
        _age = age;

        _model = new UserModel();
        UpdateCommand = new RelayCommand(_ => { UpdateUser(); }, _ => CanUpdate);
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

    public ICommand UpdateCommand { get; }

    public bool CanUpdate => !(
        string.IsNullOrWhiteSpace(Name) ||
        string.IsNullOrWhiteSpace(Age.ToString())
    );

    private void UpdateUser()
    {
        _model.Update(Id, Name, Age);
    }
}