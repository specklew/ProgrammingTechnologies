using Presentation.ViewModel.MVVM;
using Services.API;
using Services.Data;
using System.Windows.Input;

namespace Presentation.ViewModel
{
    public class UserItemViewModel : ViewModelBase
    {
        private int _id;
        private string _name;
        private int _age;

        private readonly IUserService _service;

        public UserItemViewModel(int id, string firstName, int lastName)
        {
            _id = id;
            _name = firstName;
            _age = lastName;

            _service = new UserService();
            UpdateCommand = new RelayCommand(_ => { UpdateUser(); }, _ => CanUpdate);
        }

        public UserItemViewModel()
        {
            _service = new UserService();
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
            _service.UpdateUser(Id, Name, Age);
        }
    }
}
