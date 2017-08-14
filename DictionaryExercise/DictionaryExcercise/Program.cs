using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> codingLanguages = new Dictionary<string, string>();
            string answer = "";
            string result = "";

            codingLanguages.Add("C#", "back-end");
            codingLanguages.Add("JavaScript", "full-stack");
            codingLanguages.Add("HTML", "front-end");

            char response = Convert.ToChar(Console.ReadLine().ToUpper());

            do
            {
                Console.Write("Coding languages dictionary. \n Type K to look for a language, \n D to look for a description");
                Console.WriteLine("\n L to use a key to look up a value, \n C to count the list and \n X to exit");

                switch (response)
                {
                    case 'K':
                        Console.WriteLine("Please type the name of language you would like to look for");
                        answer = Console.ReadLine();               
                        if (codingLanguages.ContainsKey(answer)
                            {
                                Console.WriteLine(answer + " is in the dictionary");
                            }
                            else
                            {
                                Console.WriteLine(answer + " is not in the dictionary");
                            }
                        break;
                    case 'D':
                        Console.WriteLine("Which description are you looking for");         
                        answer = Console.ReadLine();
                        if (codingLanguages.ContainsValue(answer)
                            {
                            Console.WriteLine(answer + " is in the dictionary");
                        }
                        else
                        {
                            Console.WriteLine(answer + " is not in the dictionary");
                        }
                        break;
                    case 'L':
                        Console.WriteLine("Which key do you want to find the description for?");
                        answer = Console.ReadLine();
                        if (codingLanguages.TryGetValue(answer, out result)
                            {
                            Console.WriteLine(answer + " has the description" + result);
                        }
                        else
                        {
                            Console.WriteLine(answer + " is not in the dictionary" + result);
                        }
                        break;
                    case 'C':
                        int dictionaryLength = codingLanguages.Count();
                        Console.WriteLine("There are " + dictionaryLength + "entries in the dictionary");
                        break;
                    default:
                        if (response != 'x')
                        {
                            Console.WriteLine("That wasn't a valid selection.");
                        }
                        break;
                }
            } while (response != 'x');
            foreach (KeyValuePair<string, string> search in codingLanguages)
            {
                Console.WriteLine(search);
            }
            Console.WriteLine();
        }
    }
}
