using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_model.Classes
{
    class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public float StartKm { get; set; }
        public float EndKm { get; set; }
        public float FuelConsumption { get; set; }
        public float TravelTime { get; set; }
        public Car(string model, int year, float startKm, float endKm, float fuelConsumption, float travelTime)
        {
            Model= model;
            StartKm= startKm;
            EndKm= endKm;
            FuelConsumption= fuelConsumption;
            TravelTime= travelTime;
        }
        public float GetTripLength()
        {
            return (EndKm - StartKm);
        }
        public float GetSpeed()
        {
            return (EndKm - StartKm) / TravelTime;
        }
        public float GetFuelEfficiency()
        {
            return (EndKm - StartKm) / (FuelConsumption/100);
        }
        public string ClassifyCar()
        {
            if(-Year + DateTime.Now.Year < 1) { return "New car, enjoy it!"; }
            if (-Year + DateTime.Now.Year >= 1 && Year - DateTime.Now.Year<3) { return "Semi-used car, how is it going?"; }
            if (-Year + DateTime.Now.Year >= 3 && Year - DateTime.Now.Year<5) { return "Used car, it's probably a good time to start looking for a new one."; }
            else { return "Old car, please change it!"; }

        }
    }
}
