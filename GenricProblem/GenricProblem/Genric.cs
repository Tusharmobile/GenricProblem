using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricProblem
{
    internal class Genric
    {
        public static string FindMaxFloatNumber(string first, string second, string third)
        {
            if ((first.CompareTo(second) > 0) && (first.CompareTo(third) > 0))
            {
                return first;
            }
            else if ((second.CompareTo(first) > 0) && (second.CompareTo(third) > 0))
            {
                return second;
            }
            else if ((third.CompareTo(second) > 0) && (third.CompareTo(first) > 0))
            {
                return third;
            }
            else
            {

                return default;
            }
        }
    }
}