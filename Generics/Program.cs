using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumber 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Program");
            MaxNumber maxNumber = new MaxNumber();
            int max=maxNumber.FindMaxNumber(20, 40, 30);
            Console.WriteLine(max);
           
        }
    }
}
