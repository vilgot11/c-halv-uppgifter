using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Uppgift18
{
    internal class Program
    {


        
        static void Main(string[] args)
        {
            myMethod();





        }
        static void myMethod()
        {
            Console.WriteLine("Enter Widght: ");
            int Widght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height: ");
            int Height = Convert.ToInt32(Console.ReadLine());

            int area = (Widght * Height) / 2;

            Console.WriteLine($"The area of the triangle is {area}");
        }

    }
        
        
    }

