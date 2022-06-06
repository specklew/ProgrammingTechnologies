using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using Presentation.Model;
using Presentation.Model.API;
using Presentation.ViewModel.MVVM;

namespace Presentation.ViewModel;

public class EventListViewModel : ViewModelBase
{
    private int _id;
    private int _userId;
    private int _productId;
    private DateTime _eventTime;
    
    private readonly IEventModel _model;
    private ObservableCollection<EventItemViewModel> _eventViewModels;
    private EventItemViewModel _selectedViewModel;
    private bool _isEventViewModelSelected;
    
    private Visibility _isEventViewModelSelectedVisibility;
    
    public EventListViewModel(IEventModel model = default(EventModel))
    {
        _model = model ?? new EventModel();
        _eventViewModels = new ObservableCollection<EventItemViewModel>();
        
        AddCommand = new RelayCommand(_ => { AddEvent(); },  _ => CanAdd);

        DeleteCommand = new RelayCommand(_ => { DeleteEvent(); }, _ => EventViewModelIsSelected());

        IsEventViewModelSelected = false;

        GetEvents();
    }
    
    public ICommand AddCommand { get; }
    public ICommand DeleteCommand { get; }

    private void AddEvent()
    {
        _model.Add(_id, _userId, _productId);
        
    }

    private void DeleteEvent()
    {
        _model.Delete(SelectedVm.Id);

        GetEvents();
        OnPropertyChanged(nameof(EventViewModels));
    }
    
    private void GetEvents()
    {
        _eventViewModels.Clear();

        foreach (var c in _model.Events)
        {
            _eventViewModels.Add(new EventItemViewModel(c.Id, c.UserId, c.ProductId));
        }

        OnPropertyChanged(nameof(EventViewModels));
    }
    
    private bool EventViewModelIsSelected()
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

    public int UserId
    {
        get => _userId;
        set
        {
            _userId = value;

            OnPropertyChanged(nameof(UserId));
        }
    }
    
    public int ProductId
    {
        get => _productId;
        set
        {
            _productId = value;

            OnPropertyChanged(nameof(ProductId));
        }
    }

    public DateTime EventTime
    {
        get => _eventTime;
        set
        {
            _eventTime = value;

            OnPropertyChanged(nameof(EventTime));
        }
    }

    public bool IsEventViewModelSelected
    {
        get => _isEventViewModelSelected;
        set
        {
            IsEventViewModelSelectedVisibility = value ? Visibility.Visible : Visibility.Hidden;
            _isEventViewModelSelected = value;
            OnPropertyChanged(nameof(IsEventViewModelSelected));
        }
    }
    
    public Visibility IsEventViewModelSelectedVisibility
    {
        get => _isEventViewModelSelectedVisibility;
        set
        {
            _isEventViewModelSelectedVisibility = value;
            OnPropertyChanged(nameof(IsEventViewModelSelectedVisibility));
        }
    }
    
    public ObservableCollection<EventItemViewModel> EventViewModels
    {
        get => _eventViewModels;

        set
        {
            _eventViewModels = value;
            OnPropertyChanged(nameof(EventViewModels));
        }
    }
    
    public EventItemViewModel SelectedVm
    {
        get => _selectedViewModel;
        set
        {
            _selectedViewModel = value;
            IsEventViewModelSelected = true;
            OnPropertyChanged(nameof(SelectedVm));
        }
    }
    
    public bool CanAdd => !(
        string.IsNullOrWhiteSpace(Id.ToString()) || 
        string.IsNullOrWhiteSpace(UserId.ToString()) || 
        string.IsNullOrWhiteSpace(ProductId.ToString())
        );
}