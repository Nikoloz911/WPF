using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPF.ViewModel
{
    public class Wisol : INotifyPropertyChanged
    {
        private Dictionary<string, double> _fuelPrices = new Dictionary<string, double>
        {
            { "Regular", 2.70 }, 
            { "Premium", 2.90 },
            { "Diesel", 2.80 }
        };

        private string _selectedFuelType;
        private string _liters;
        private double _totalPrice;

        public Wisol()
        {
            _selectedFuelType = "Regular";
        }
        public List<string> FuelTypes => new List<string>(_fuelPrices.Keys);

        public string SelectedFuelType
        {
            get => _selectedFuelType;
            set
            {
                if (_selectedFuelType != value)
                {
                    _selectedFuelType = value;
                    CalculateTotalPrice();
                    OnPropertyChanged();
                }
            }
        }

        public string Liters
        {
            get => _liters;
            set
            {
                if (_liters != value)
                {
                    _liters = value;
                    CalculateTotalPrice();
                    OnPropertyChanged();
                }
            }
        }

        public double TotalPrice
        {
            get => _totalPrice;
            private set
            {
                _totalPrice = value;
                OnPropertyChanged();
            }
        }
        private void CalculateTotalPrice()
        {
            if (double.TryParse(Liters, out double liters))
            {
                if (_fuelPrices.ContainsKey(SelectedFuelType))
                {
                    TotalPrice = liters * _fuelPrices[SelectedFuelType];
                }
                else
                {
                    TotalPrice = 0;
                }
            }
            else
            {
                TotalPrice = 0;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
