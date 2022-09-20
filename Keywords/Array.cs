using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keywords
{
    internal class Array
    {
        internal static void copy(int[] numbers, int[] nums, int length)
        {
            throw new NotImplementedException();
        }

        internal static int IndexOf(int[] numbers, int v)
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 10, 20, 30, 40, 50 };

            string[] names = { "Tushar", "Rohan", "Suraj", "Raj" };

            for (int i = 0; i <numbers.Length; i++)
            {
                Console.WriteLine($"numbers {i} = {numbers[i]}");
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"names {i} = {names[i]}");
            }
        }

    }
}
//if you want accept value from user then .....
  //  static void Main(string[] args)
  // {
  //   int[] numbers = new int[5];

  //  string[] names = { "Tushar", "Rohan", "Suraj", "Raj" };
  //  Console.WriteLine("Enter 5 elements");
  //  for (int i = 0; i <numbers.Length; i++)
  //   {
  //     numbers[i] = Convert.ToInt32(Console.ReadLine());
  //  }
  //  Console.WriteLine("----------------------");
  //      for (int i = 0; i < numbers.Length; i++)
  //   {
  //     Console.WriteLine($"numbers {i} = {numbers[i]}");
  //     }
  //    }
