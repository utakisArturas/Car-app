using System;

namespace CA0221
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Mazda",-5,76);
            car.Drive();
            car.Refuel(15);
            car.Drive();
        }
    }
}
