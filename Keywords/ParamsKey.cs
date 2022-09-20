using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keywords
{
    internal class ParamsKey
    {

        static void AcceptNames(params string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);

            }
        }
        static void Main(string[] args)
        {
            AcceptNames("Rahul", "Kishor", "Tushar");
            AcceptNames("Rahul", "Kishor");
            AcceptNames("Rahul", "Kishor", "Tushar", "Raj");

        }
    }
}