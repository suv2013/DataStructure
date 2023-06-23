using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure.Array;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter 1 for Array Rotation.");

            int value = Convert.ToInt32(Console.ReadLine());

            switch (value)
            {
                case 1:
                    ArrayOperations.ArrayRotation();
                    break;

                default:
                    Console.WriteLine("Please visit next time.");
                    break;
            }
        }
    }
}
