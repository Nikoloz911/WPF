using WPF.Model;

namespace WPF.ViewModel;
internal class ProductVM : Utilities.ViewModelBase
{
    private readonly PageModel _pageModel;
    public string ProductAvailability
    {
        get { return _pageModel.ProductStatus; }
        set { _pageModel.ProductStatus = value; OnPropertyChanged(); }
    }

    public ProductVM()
    {
        _pageModel = new PageModel();
        ProductAvailability = "Out of Stock";
    }
}
