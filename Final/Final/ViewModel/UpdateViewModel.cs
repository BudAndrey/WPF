using Final.infrasructure;
using Final.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Final.ViewModel
{
    class UpdateViewModel:Notifyer
    {
        private Car editCar=new Car();
        public Car EditCar { get=>editCar; set { editCar = value;Notify(); } }
        public UpdateViewModel(MainViewModel main)
        {
            editCar.Id = main.SelectedCar.Id;
            editCar.Title = main.SelectedCar.Title;
            editCar.Model = main.SelectedCar.Model;
            editCar.Year = main.SelectedCar.Year;
            editCar.Color = main.SelectedCar.Color;
            editCar.ImageUrl = main.SelectedCar.ImageUrl;
            ChangeCommand = new RelayCommand(x =>
            {
                main.SelectedCar.Title = EditCar.Title;
                main.SelectedCar.Model = EditCar.Model;
                main.SelectedCar.Year = EditCar.Year;
                main.SelectedCar.Color = EditCar.Color;
                main.SelectedCar.ImageUrl = EditCar.ImageUrl;
                main.SelectedCar = EditCar;
            }
                );
        }
        public ICommand ChangeCommand { get; set; }
    }
}
