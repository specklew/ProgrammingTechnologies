using System;
using System.Windows.Input;
using Presentation.Model;
using Presentation.Model.API;
using Presentation.ViewModel.MVVM;

namespace Presentation.ViewModel;

public class EventItemViewModel : ViewModelBase
{
    private int _id;
    private int _userId;
    private int _productId;
    private DateTime _eventTime;

    private readonly IEventModel _model;

    public EventItemViewModel(int id = 0, int userId = 0, int productId = 0, DateTime eventTime = default, IEventModel model = default(EventModel))
    {
        _id = id;
        _userId = userId;
        _productId = productId;
        _eventTime = eventTime;

        _model = model ?? new EventModel();
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
        _model.Update(_id, _userId, _productId);
    }
}