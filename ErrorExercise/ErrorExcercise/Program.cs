using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ErrorExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = null;
           try
            {
                sr = File.OpenText(@"C:\Users\student\Desktop\Kai\Week-3-C#\ErrorExercise\mydata.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch(FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("and the program continues...");

        }
    }
}
