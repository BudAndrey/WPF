using Final.infrasructure;
using Final.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Final.ViewModel
{
    public class CreateViewModel
    {
        private MainViewModel maincars;
        public Car NewCar { get; set; }
        public int Year { get; set; }
        public CreateViewModel(MainViewModel mainViewModel)
        {
            maincars = mainViewModel;
            NewCar = new Car();
            AddCommand = new RelayCommand(x =>
              {
                  if (maincars.Cars == null)
                  {
                      NewCar.Year = Year;  
                      maincars.Cars = new ObservableCollection<Car>();
                      maincars.Cars.Add(NewCar);
                      maincars.SelectedCar = NewCar;
                  }
                  else
                  {
                      NewCar.Year = Year;
                      maincars.Cars.Add(NewCar);
                      maincars.SelectedCar = NewCar;
                  }
              });
        }
        public ICommand AddCommand { get; private set; }
    }
}
