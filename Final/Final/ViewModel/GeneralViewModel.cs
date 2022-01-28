using Final.infrasructure;
using Final.Model;
using Final.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.ViewModel
{
    public class GeneralViewModel:Notifyer
    {
        private double slider;
        //public GeneralViewModel(Car car)
        //{
        //    SelectedCar = car;
        //}
        public GeneralViewModel(Car car,double width, GeneralView view)
        {
            slider = view.Width ;
            SelectedCar = car;
            if (width!=0)
                slider = width;
        }
        public double Slider { get=>slider; set { slider = value;Notify(); } }
        public Car SelectedCar { get; set; }

    }
}
