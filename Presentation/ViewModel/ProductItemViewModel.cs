using System.Globalization;
using System.Windows.Input;
using Presentation.Model;
using Presentation.Model.API;
using Presentation.ViewModel.MVVM;
using Services.API;
using Services.Data;

namespace Presentation.ViewModel;

public class ProductItemViewModel : ViewModelBase
{
    private int _id;
    private string _name;
    private string _description;
    private int _price;

    private readonly IProductModel _model;

    public ProductItemViewModel(int id = 0, string name = null, string description = null, int price = 0)
    {
        _id = id;
        _name = name;
        _description = description;
        _price = price;

        _model = new ProductModel();
        UpdateCommand = new RelayCommand(_ => { UpdateProduct(); }, _ => CanUpdate);
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
    
    public string Description
    {
        get => _description;
        set
        {
            _description = value;

            OnPropertyChanged(nameof(Description));
        }
    }

    public int Price
    {
        get => _price;
        set
        {
            _price = value;

            OnPropertyChanged(nameof(Price));
        }
    }
    
    public ICommand UpdateCommand { get; }

    public bool CanUpdate => !(
        string.IsNullOrWhiteSpace(Id.ToString()) || 
        string.IsNullOrWhiteSpace(Name) || 
        string.IsNullOrWhiteSpace(Description) ||
        string.IsNullOrWhiteSpace(Price.ToString(CultureInfo.CurrentCulture)
        ));
    
    private void UpdateProduct()
    {
        _model.Update(_id, _name, _description, _price);
    }
}