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
            

            GenricMaximum<int> first = new GenricMaximum<int>();
            first.FindMax(1, 2, 3);
            Console.ReadLine();
        }
    }
}
