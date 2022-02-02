using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int max = Genric.FindMaxIntNumber(a, b, c);
            if (max == 0)

            {
                Console.WriteLine("All three numbers are equal!!!");
            }
            else
            {
                
                Console.WriteLine("Maximum among three:" + max);
                Console.ReadLine();
               
            }
        } 
    }
}
    

