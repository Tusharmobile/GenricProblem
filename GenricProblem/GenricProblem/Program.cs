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
            Console.WriteLine("Enter three words:");
            
            int[] arr = { 1, 2, 3, 4, 5 };
            GenricMaximum<int> obj = new GenricMaximum<int>(arr);
            obj.PrintMaxValue();
            string[] Stringarr = { "abc", "efg", "hij" };

            GenricMaximum<string> obj1 = new GenricMaximum<string>(Stringarr);
            obj1.PrintMaxValue();
            char[] Chararr = { 'a', 'b', 'c', };
            GenricMaximum<char> obj2 = new GenricMaximum<char>(Chararr);
            obj2.PrintMaxValue();
            float[] Floatarr = { 1.1f, 1.2f, 1.3f };
            GenricMaximum<float> obj3 = new GenricMaximum<float>(Floatarr);
            obj3.PrintMaxValue();
            Console.ReadLine();
        }
    }
}

