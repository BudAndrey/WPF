using Final.Model;
using Final.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Final.View
{
    /// <summary>
    /// Логика взаимодействия для GeneralView.xaml
    /// </summary>
    public partial class GeneralView : UserControl
    {

        //public GeneralView(Car car)
        //{
        //    this.DataContext = new GeneralViewModel(car);
        //    InitializeComponent();
        //}
        public GeneralView(Car car,double width)
        {
            this.DataContext = new GeneralViewModel(car,width,this);
            InitializeComponent();

        }
    }
}
