using Final.infrasructure;
using Final.Model;
using Final.View;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Final.ViewModel
{
    public class MainViewModel:Notifyer
    {
        private Car selectedCar;
        private UserControl view;
        private double slider;
        private ObservableCollection<Car> cars;
        private ResourceDictionary theme;
        private MainWindow window;
        public UserControl CurrentView
        { get=>view; set { view = value;Notify(); } }
        public ObservableCollection<Car> Cars 
        { get=>cars;
            set 
            {
                cars = value;
                Notify();
            }
        }
        public Car SelectedCar 
        { 
            get=>selectedCar;
            set
            {
                selectedCar = value;
                CurrentView = new GeneralView(selectedCar,slider);
                Notify();
            }
        }
        public double Slider { 
            get => slider; 
            set 
            { 
                slider = value;
                CurrentView = new GeneralView(selectedCar,slider);
                Notify(); 
            } }
        public MainViewModel(MainWindow wind)
        {
            //cars = new ObservableCollection<Car>(Car.GetCars());
            theme = new ResourceDictionary();
            theme.Source = new Uri(Environment.CurrentDirectory + "\\..\\..\\LightTheme.xaml");
            window = wind;
            window.Resources = theme;
            InitCommands();
        }

        private void InitCommands()
        {
            SaveCommand = new RelayCommand(x =>
            {
                string json = JsonConvert.SerializeObject(Cars, Formatting.Indented);
                SaveFileDialog save = new SaveFileDialog();
                save.Filter= "Json file (*.json)|*.json|All files (*.*)|*.*";
            if (save.ShowDialog() == true)
                File.WriteAllText(save.FileName, json);
            });
            LoadCommand = new RelayCommand(x =>
            {
                string path = null;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    path = openFileDialog.FileName;
                }
                string json = File.ReadAllText(path);
                Cars = JsonConvert.DeserializeObject<ObservableCollection<Car>>(json);
            });
            RemoveCommand = new RelayCommand(x =>cars?.Remove(SelectedCar));
            CreateCommand = new RelayCommand(x =>CurrentView = new CreateView(this));
            UpdateCommand = new RelayCommand(x => CurrentView = new UpdateView(this),x=>selectedCar!=null);
            SortYearCommand = new RelayCommand(x => 
            {
                var ordered= Cars.OrderBy(t => t.Year);
                Cars = new ObservableCollection<Car>(ordered);
            } );
            SortModelCommand = new RelayCommand(x =>
            {
                var ordered = Cars.OrderBy(t => t.Model);
                Cars = new ObservableCollection<Car>(ordered);
            });
            SortTitleCommand = new RelayCommand(x =>
            {
                var ordered = Cars.OrderBy(t => t.Title);
                Cars = new ObservableCollection<Car>(ordered);
            });
            SortColorCommand = new RelayCommand(x =>
            {
                var ordered = Cars.OrderBy(t => t.Color);
                Cars = new ObservableCollection<Car>(ordered);
            });
            LightViewCommand = new RelayCommand(x =>
            {
                theme.Source = new Uri(Environment.CurrentDirectory + "\\..\\..\\LightTheme.xaml");
                window.Resources = theme;
            });
            DarkViewCommand = new RelayCommand(x =>
            {
                theme.Source = new Uri(Environment.CurrentDirectory + "\\..\\..\\DarkTheme.xaml");
                window.Resources = theme;
            });

        }

        // public ICommand ScrollBarCommand { get; private set; }
        public ICommand SaveCommand { get; private set; }
        public ICommand LoadCommand { get; private set; }
        public ICommand RemoveCommand { get; private set; }
        public ICommand CreateCommand { get; private set; }
        public ICommand UpdateCommand { get; private set; }
        public ICommand SortYearCommand { get; private set; }
        public ICommand SortTitleCommand { get; private set; }
        public ICommand SortModelCommand { get; private set; }
        public ICommand SortColorCommand { get; private set; }
        public ICommand LightViewCommand { get; private set; }
        public ICommand DarkViewCommand { get; private set; }

    }
}
