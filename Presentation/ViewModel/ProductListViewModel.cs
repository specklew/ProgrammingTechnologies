using Presentation.ViewModel.MVVM;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using Services.Data;

namespace Presentation.ViewModel;

public class ProductListViewModel : ViewModelBase
{
    private int _id;
    private string _name;
    private string _description;
    private float _price;

    private readonly ProductService _service;
    private ObservableCollection<ProductItemViewModel> _productViewModels;
    private ProductItemViewModel _selectedViewModel;
    private bool _isProductViewModelSelected;
    
    private Visibility _isProductViewModelSelectedVisibility;

    public ProductListViewModel()
    {
        _service = new ProductService();
        _productViewModels = new ObservableCollection<ProductItemViewModel>();
        
        AddCommand = new RelayCommand(_ => { AddProduct(); },  _ => CanAdd);

        DeleteCommand = new RelayCommand(_ => { DeleteProduct(); }, _ => ProductViewModelIsSelected());

        IsProductViewModelSelected = false;

        GetProducts();
    }
    
    public ICommand AddCommand { get; }
    public ICommand DeleteCommand { get; }
    
    private void AddProduct()
    {
        _service.AddProduct(_id, _name, _description, _price);
    }

    private void DeleteProduct()
    {
        _service.DeleteProduct(SelectedVm.Id);

        GetProducts();
        OnPropertyChanged(nameof(ProductViewModels));
    }
    
    private void GetProducts()
    {
        _productViewModels.Clear();

        foreach (var c in _service.GetAllProducts())
        {
            _productViewModels.Add(new ProductItemViewModel(c.Id, c.Name, c.Description, c.Price));
        }

        OnPropertyChanged(nameof(ProductViewModels));
    }
    
    private bool ProductViewModelIsSelected()
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
    
    public string Description
    {
        get => _description;
        set
        {
            _description = value;

            OnPropertyChanged(nameof(Description));
        }
    }

    public float Price
    {
        get => _price;
        set
        {
            _price = value;

            OnPropertyChanged(nameof(Price));
        }
    }

    public bool IsProductViewModelSelected
    {
        get => _isProductViewModelSelected;
        set
        {
            IsProductViewModelSelectedVisibility = value ? Visibility.Visible : Visibility.Hidden;
            _isProductViewModelSelected = value;
            OnPropertyChanged(nameof(IsProductViewModelSelected));
        }
    }
    
    public Visibility IsProductViewModelSelectedVisibility
    {
        get => _isProductViewModelSelectedVisibility;
        set
        {
            _isProductViewModelSelectedVisibility = value;
            OnPropertyChanged(nameof(IsProductViewModelSelectedVisibility));
        }
    }
    
    public ObservableCollection<ProductItemViewModel> ProductViewModels
    {
        get => _productViewModels;

        set
        {
            _productViewModels = value;
            OnPropertyChanged(nameof(ProductViewModels));
        }
    }
    
    public ProductItemViewModel SelectedVm
    {
        get => _selectedViewModel;
        set
        {
            _selectedViewModel = value;
            IsProductViewModelSelected = true;
            OnPropertyChanged(nameof(SelectedVm));
        }
    }
    
    public bool CanAdd => !(
        string.IsNullOrWhiteSpace(Name) || 
        string.IsNullOrWhiteSpace(Description) ||
        Price == 0.0f
        );
}