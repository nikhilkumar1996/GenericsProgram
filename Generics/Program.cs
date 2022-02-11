using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumber 
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Program");
            int[] intarray = { 1, 2, 3, 4, 5, 6, 7, 8, };
            double[] doubleArray = { 1.1, 1.2, 1.3, 1.4, 1.5, 1.6 };
            string[] stringArray = { "Apple", "Banana", "Peach", "Mangoes", "JackFruit" };
            MaxNumber.Print(intarray);
            MaxFloatNumber.Display(doubleArray);
            MaxString.Execute(stringArray);



        }
    }
}
