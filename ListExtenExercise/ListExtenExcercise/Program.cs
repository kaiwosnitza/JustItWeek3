using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BookCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookToAdd, bookToDelete;
            List<string> myBooks = new List<string>() { "The Hunger Games", "Catching Fire", "Mockingjay", "The Hitchhikers Guide to the Galaxy" };
            Console.WriteLine("Here is your book collection.  To add a book, press A; to delete a book, press D; to list all books, press L; to sort all books, press S:");
            Console.WriteLine("To exit, press X.");
            char response = Convert.ToChar(Console.ReadLine().ToUpper());
            do
            {
                switch (response)
                {
                    case 'A':
                        Console.WriteLine("Type the name of the book you would like to add:");
                        bookToAdd = Console.ReadLine();
                        myBooks.Add(bookToAdd);
                        break;
                    case 'D':
                        Console.WriteLine("Type the name of the book you would like to delete:");
                        bookToDelete = Console.ReadLine();
                        myBooks.Remove(bookToDelete);
                        break;
                    case 'L':
                        for (int i = 0; i < myBooks.Count; i++)
                        {
                            Console.WriteLine(myBooks[i]);
                        }
                        break;
                    case 'S':
                        myBooks.Sort();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("What would you like to do next: A, D, L, S or X?:");
                response = Convert.ToChar(Console.ReadLine().ToUpper());
            }
            while (response != 'X');
        }
    }
}
