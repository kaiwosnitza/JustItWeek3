using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAddCarExercise
{
    class Car
    {
        public string Make;
        public string Model;
        public int Price;

        public static int numberOfCars;

        public Car(string Make, string Model, int Price)

    }

    class Program
    {
        static void Main(string[] args)
        {
            string response = "";
            string Make = "";
            string Model = "";
            int Price = 0;

            List<string> Car = new List<string>() ;

            Console.WriteLine("Welcome. To add a car press A; to exit, press X.");
            char response = Convert.ToChar(Console.ReadLine().ToUpper());

            do
            {
                Console.WriteLine("Please type A to add a car to the list or X to exit:");
                response = Console.ReadLine().ToUpper();

                if (response == 'A')
                {
                    Console.WriteLine("Please enter a make:");
                    Make = Console.ReadLine();
                    Console.WriteLine("Please enter a model:");
                    Model = Console.ReadLine();
                    Console.WriteLine("Please enter a price:");
                    Price = Convert.ToInt32(Console.ReadLine());

                    Car myCar = new Car(Make, Model, Price);
                    carList.Add(myCar);

                    Console.WriteLine("\Here is the current list of cars:\n");
                    foreach (Car car in carList);

                    {
                        Console.WriteLine("Make: {0}", car.Make);
                        Console.WriteLine("Make: {0}", car.Model);
                        Console.WriteLine("Make: {0} \n", car.Price);
                    }              
                }

            }
            while (response != 'X');

        }
    }
}
