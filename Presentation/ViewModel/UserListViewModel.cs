using Presentation.Model;
using Presentation.ViewModel.MVVM;

namespace Presentation.ViewModel;

public class UserListViewModel : ViewModelBase
{
    private UserModelData _userData;
    
    public UserListViewModel()
    {
        _userData = new UserModelData();
    }
    
    public UserListViewModel(UserModelData userData)
    {
        _userData = userData;
    }
}