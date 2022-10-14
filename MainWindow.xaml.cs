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
using Car_model.Classes;

namespace Car_model
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Car car;
        public MainWindow()
        {
            InitializeComponent();
        }
        void Save_Car(string model, int year, float startKm, float endKm, float fuelConsumption, float travelTime)
        {
            car = new Car(model,year,startKm,endKm,fuelConsumption,travelTime);
            string data = string.Empty;                 
            data = $"Model: {car.Model}, Year: {car.Year}, StartKm: {car.StartKm}, EndKm: {car.EndKm}, FuelConsumption: {car.FuelConsumption}, TravelTime: {car.TravelTime}{Environment.NewLine}";
            MessageBox.Show(data);
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            string model= TextBoxModel.Text;
            int year;
            float startKm;
            float endKm;
            float fuelConsumption;
            float travelTime;
            if(int.TryParse(TextBoxYear.Text, out year)==false)
            {
                MessageBox.Show("You must enter a valid year ", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (float.TryParse(TextBoxStratKm.Text, out startKm) == false)
            {
                MessageBox.Show("You must enter a valid startink kilometer","Error", MessageBoxButton.OK,MessageBoxImage.Error);
            }
            if (float.TryParse(TextBoxEndKm.Text, out endKm) == false)
            {
                MessageBox.Show("You must enter a valid endink kilometer", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (float.TryParse(TextBoxFuelConsumption.Text, out fuelConsumption) == false)
            {
                MessageBox.Show("You must enter a valid fuel consumption", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (float.TryParse(TextBoxTravelTime.Text , out travelTime) == false)
            {
                MessageBox.Show("You must enter a valid travel time", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            car = new Car(model, year, startKm, endKm, fuelConsumption, travelTime);
        }

        private void ButtonGetTripLength_Click(object sender, RoutedEventArgs e)
        {
            if (car.GetTripLength()>=0) { MessageBox.Show("The trip length was : " + car.GetTripLength()+" km", "Ok", MessageBoxButton.OK, MessageBoxImage.Information); }
            else { MessageBox.Show("Your distance is negative, please enter another starting or ending kilometer", "Error", MessageBoxButton.OK, MessageBoxImage.Error); }
        }

        private void ButtonGetSpeed_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The average speed was : "+car.GetSpeed()+" km/h","Ok",MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ButtonGetFuelEfficiency_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The liters per 100km fuel efficiency is : "+car.GetFuelEfficiency(),"Ok",MessageBoxButton.OK,MessageBoxImage.Information);
        }

        private void ButtonClassifyCar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(car.ClassifyCar(), "Ok", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
