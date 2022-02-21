using System;

namespace CA0221
{
    public class Car : IVehicle
    {
        public string Model { get; set; }
        public int Fuel { get; set; }
        public int GasTankCapacity { get; set; }

        public Car(string model, int fuel, int gasTankCapacity)
        {
            Model = model;
            Fuel = fuel;
            GasTankCapacity = gasTankCapacity;
        }

        public void Drive() 
        {
            if (Fuel > 0)
            {
                Console.WriteLine("You can drive");
            }
            else
            {
                Console.WriteLine("Gas tank is empty, refuel");
            }

        }

        public void Refuel(int liters)
        {
            if (liters> 0 && liters <= GasTankCapacity)
            {
                Fuel = liters;
            }
        }
    }
}
