using WPF.Model;
namespace WPF.ViewModel;
internal class OrderVM : Utilities.ViewModelBase
{
    private readonly PageModel _pageModel;
    public DateOnly DisplayOrderDate
    {
        get { return _pageModel.OrderDate; }
        set { _pageModel.OrderDate = value; OnPropertyChanged(); }
    }

    public OrderVM()
    {
        _pageModel = new PageModel();
        DisplayOrderDate = DateOnly.FromDateTime(DateTime.Now);
    }
}
