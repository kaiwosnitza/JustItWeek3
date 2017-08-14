using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOCarExercise
{
    class Car
    {
        public string make;
        public string model;
        public int price;
        public int doors;
        public Boolean sold;

        public static int numberOfCars;

        public Car(string make, string model, int price, int doors)

        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.doors = doors;
            this.sold = false;
            Car.numberOfCars++;
        }
        public static void DisplayAllCars(List<Car>carList)
        {
            int totalValueSold = 0;
            int totalValueStock = 0;

            foreach (Car c in carList)
            {
                Console.WriteLine("The details of this car are: ");
                Console.WriteLine("Make and model: {0} {1}, price: £{2:N0}, number of doors: {3}.", c.make, c.model, c.price, c.doors);
                if (c.sold)
                {
                    Console.WriteLine("This car has been sold.");
                    totalValueSold += c.price;
                }
                else
                {
                    Console.WriteLine("This car is unsold.");
                    totalValueStock += c.price;
                }
                Console.WriteLine();
            }
            Console.WriteLine("The total value of cars sold is: £{0:N0}.", totalValueSold);
            Console.WriteLine("The total value of cars in stock is: £{0:N0}.", totalValueStock);

        }

        public void Sold(int price)
        {
            this.sold = true;
            this.price = price;
            Car.numberOfCars--;
            Console.WriteLine("The {0} has been sold for £{1:N0}.", this.make, this.price);
        }

    }

        class Program

        { 
            static void Main(string[] args)
            {
                Car.numberOfCars = 0;

                Car car1 = new Car("Vauxhall", "Astra", 15500, 5);

                Car car2 = new Car("BMW", "5 Series", 50000, 4);

                Car car3 = new Car("Mercedes-Benz", "S Class", 70000, 4);

            List<Car> carList = new List<Car>();
            carList.Add(car1);
            carList.Add(car2);
            carList.Add(car3);

            Console.WriteLine("Total number of cars in stock is: {0}", Car.numberOfCars);
            Console.WriteLine();

            Car.DisplayAllCars(carList);

            car1.Sold(20000);

            Console.WriteLine();

            Console.WriteLine("Total number of cars in stock is: {0}", Car.numberOfCars);
            Console.WriteLine();

            Car.DisplayAllCars(carList);

        }
    }
}
