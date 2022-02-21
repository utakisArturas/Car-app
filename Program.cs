using System;

namespace CA0221
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Mazda",30,76);
            car.Drive();
            car.Refuel(46);
            car.Drive();
            car.Refuel(1);
        }
    }
}
