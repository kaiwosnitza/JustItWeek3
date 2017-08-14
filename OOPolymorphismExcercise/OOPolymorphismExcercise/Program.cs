using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPolymorphismExcercise
{
    class Vehicle
    {
        public virtual void Wheels()
        {
            Console.WriteLine("A vehicle has X amount of wheels.");
        }
    }
    class Car : Vehicle
    {
        public override void Wheels()
        {
            Console.WriteLine("A car has 4 wheels.");
        }
    }
    class Bike : Vehicle
    {
        public new void Wheels()
        {
            Console.WriteLine("A bike has 2 wheels.");
        }
    }
    class Program
    {
        static void Main (string[] args)
        {
            List<Vehicle> Vehicles = new List<Vehicle>();
            Vehicles.Add(new Vehicle());
            Vehicles.Add(new Car());        //Car that has been cast as a vehicle
            Vehicles.Add(new Bike());       //Bike that has been cast as a vehicle
            foreach (Vehicle p in Vehicles)
            {
                p.Wheels();
            }
            Bike Bike1 = new Bike();
            Bike1.Wheels();
        }
    }
}
