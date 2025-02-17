using WPF.Model;
namespace WPF.ViewModel;
internal class CustomerVM : Utilities.ViewModelBase
{
    private readonly PageModel _pageModel;
    public int CustomerID
    {
        get { return _pageModel.CustumerCount; }
        set { _pageModel.CustumerCount = value; OnPropertyChanged(); }
    }

    public CustomerVM()
    {
        _pageModel = new PageModel();
        CustomerID = 100528;
    }
}
