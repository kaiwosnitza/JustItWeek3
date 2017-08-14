using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarSalesConstructors
{
    class Vehicle
    {
        public string make;
        public string model;
        public int price;
        public Boolean sold;
        //public int wheels;

        public static int numberOfVehicles;
        //AddCar method changed to a constructor by changing its name to Car (same as the class)
        //and removing its return type
        public Vehicle(string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            //this.wheels = 4;
            //this.passengers = 5;

        }
        //another constructor is added for cars with an unusual number of wheels
        public Vehicle(string make, string model, int price, int wheels)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            //this.wheels = wheels;
            //this.passengers = 5;

        }

        public void ListVehicle()
        {
            //display details for an individual car
            Console.WriteLine("The details of this vehicle are: ");
            Console.Write("Make and model: {0} {1}, price: £{2:N0}.", make, model, price);  //:N0 formats the number
            if (sold)
            {
                Console.WriteLine("This vehicle has been sold.");
            }
            else
            {
                Console.WriteLine("This vehicle has not yet been sold.");
            }
            Console.WriteLine();
        }
        //record the sale of a car
        public void Sold(bool isSold, int price)
        {
            this.sold = isSold;
            this.price = price;
            //adjust the number of cars
            if (this is Car)
            {
                Car.numberOfCars--;
            }

            if (this is Bike)
            {
                Bike.numberOfBikes--;
            }
        }
        //list all the cars
        public static void DisplayAllVehicles(List<Vehicle> allVehicles)
        {
            int totalValueSold = 0;
            int totalValueInStock = 0;
            foreach (Vehicle item in allVehicles)
            {
                Console.WriteLine("The details of this vehicle are: ");
                Console.Write("Make and model: {0} {1}, price: £{2:N0}.", item.make, item.model, item.price);  //:N0 formats the number
                if (item.sold)
                {
                    Console.WriteLine("This vehicle has been sold.");
                    totalValueSold += item.price;
                }
                else
                {
                    Console.WriteLine("This vehicle is unsold.");
                    totalValueInStock += item.price;
                }
                Console.WriteLine();
            }
            Console.WriteLine("The total value of vehicle sold is: £{0:N0}.", totalValueSold);
            Console.WriteLine("The total value of vehicle still in stock is: £{0:N0}.", totalValueInStock);
            Console.WriteLine();
        }
    }

    class Car : Vehicle
    {
        public string type;
        public static int numberOfCars;


        public Car(string make, string model, int price) : base(make, model, price)
        {
            this.type = "car";
            this.make = make;
            this.model = model;
            this.price = price;

            numberOfCars++;
        }
    }

    class Bike : Vehicle
    {
        public string type;
        public static int numberOfBikes;


        public Bike(string make, string model, int price) : base(make, model, price)
        {
            this.type = "bike";
            this.make = make;
            this.model = model;
            this.price = price;

            numberOfBikes++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car.numberOfVehicles = 0;
            List<Vehicle> allVehicles = new List<Vehicle>();
            //add cars using the constructor
            Car car1 = new Car("Vauxhall", "Astra", 15500);
            allVehicles.Add(car1);
            Car car2 = new Car("BMW", "5-Series", 55000);
            allVehicles.Add(car2);
            Car car3 = new Car("Mercedes-Benz", "S-Class", 70000);
            allVehicles.Add(car3);

            Bike.numberOfVehicles = 0;
            //add bikes using the constructor
            Bike bike1 = new Bike("KTM", "450 SF-X", 7500);
            allVehicles.Add(bike1);
            Bike bike2 = new Bike("Yamaha", "YZF-R6", 11000);
            allVehicles.Add(bike2);
            Bike bike3 = new Bike("BMW", "R 1200 GS", 12400);
            allVehicles.Add(bike3);

            //display cars data
            Console.WriteLine("Total number of cars in stock is: {0}", Car.numberOfCars);
            Console.WriteLine("Total number of bikes in stock is: {0}", Bike.numberOfBikes);
            Console.WriteLine();
            Car.DisplayAllVehicles(allVehicles);
            //Bike.DisplayAllVehicles(allVehicles);
            //record the sale of a car
            car1.Sold(true, 20000);
            bike1.Sold(true, 10000);
            //display cars data
            Console.WriteLine("Total number of cars in stock is: {0}", Car.numberOfCars);
            Console.WriteLine("Total number of bikes in stock is: {0}", Bike.numberOfBikes);
            Console.WriteLine();
            Car.DisplayAllVehicles(allVehicles);
            //Bike.DisplayAllVehicles(allVehicles);



        }
    }
}