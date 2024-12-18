using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluetagTasks1
{

    class Program
    {
        static void Main(string[] args)
        {
            taskone();  
        }
        static void taskone()
        {
            // the veriables/ decelaration
            double A, b, C, D, T;
            Console.WriteLine("Enter the value A:");
            A = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value C:");
            C = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value D:");
            D = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value T:");
            T = double.Parse(Console.ReadLine());


            double denominator = 4 * A * C;
            double Result1 = Math.Sqrt((A * b) / (2 * D));
            double Result2 = Math.Sqrt(Math.Pow((Math.Sqrt(T * C)) / (2 * D), 2));
            double Answer = (Result1 * (-3) * Result2) / denominator;
            Console.WriteLine($"Task One Final Answer is:\t {Answer}");
            Console.WriteLine("press any key exisit:");
            Console.ReadLine();

        }
    }
}
