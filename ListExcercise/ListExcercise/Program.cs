using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookToAdd;

            List<string> myBooks = new List<string>() { "Lord of the Rings", "The Hobbit", "Game of Thrones", "Harry Potter" };

            Console.WriteLine("Welcome to your library. To add a book press A; to exit, press X.");
            char response = Convert.ToChar(Console.ReadLine().ToUpper());

            do
            {
                if (response == 'A')
                {
                    Console.WriteLine("Please type the name of the book you would like to add:");
                    bookToAdd = Console.ReadLine();
                    myBooks.Add(bookToAdd);
                }
                Console.WriteLine("What would you like to add another book or exit?");
                response = Convert.ToChar(Console.ReadLine().ToUpper());
            }
            while (response != 'X');

            foreach(string title in myBooks)
            {
                Console.WriteLine(title);
            }
        }
    }
}
