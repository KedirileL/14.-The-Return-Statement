using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.The_Return_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The cube of the number you entered is ");
            Console.WriteLine(Cube(5));

            //Freeze console
        }

        static int Cube(int x)
        {
            return x*x*x; 
        }
    }
}
