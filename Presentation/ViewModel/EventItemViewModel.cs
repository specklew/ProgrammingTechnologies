using System;
using System.Windows.Input;
using Presentation.ViewModel.MVVM;
using Services.API;
using Services.Data;

namespace Presentation.ViewModel;

public class EventItemViewModel : ViewModelBase
{
    private int _id;
    private int _userId;
    private int _productId;
    private DateTime _eventTime;

    private readonly IEventService _service;

    public EventItemViewModel(int id, int userId, int productId, DateTime eventTime)
    {
        _id = id;
        _userId = userId;
        _productId = productId;
        _eventTime = eventTime;

        _service = new EventService();
        UpdateCommand = new RelayCommand(_ => { UpdateEvent(); }, _ => CanUpdate);
    }
    
    public EventItemViewModel(int id, int userId, int productId)
    {
        _id = id;
        _userId = userId;
        _productId = productId;

        _service = new EventService();
        UpdateCommand = new RelayCommand(_ => { UpdateEvent(); }, _ => CanUpdate);
    }

    public EventItemViewModel()
    {
        _service = new EventService();
        UpdateCommand = new RelayCommand(_ => { UpdateEvent(); }, _ => CanUpdate);
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
    
    public ICommand UpdateCommand { get; }

    public bool CanUpdate => !(
        string.IsNullOrWhiteSpace(Id.ToString()) || 
        string.IsNullOrWhiteSpace(UserId.ToString()) || 
        string.IsNullOrWhiteSpace(ProductId.ToString())
    );
    
    private void UpdateEvent()
    {
        _service.UpdateEvent(_id, _userId, _productId);
    }
}