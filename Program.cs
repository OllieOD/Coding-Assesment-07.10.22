using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Assesment_07._10._22
{
    internal class Program
    {
        static void main(string[] args)
        {
            Console.WriteLine("Enter a whole number");
            int Number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a whole number");
            int Number2 = int.Parse(Console.ReadLine());
            int Temp1 = Number1;
            int Temp2 = Number2;
            while (Temp1 != Temp2)
            {
                if (Temp1 > Temp2)
                {
                    Temp1 = Temp1 - Temp2;
                }
                else
                {
                    Temp2 = Temp2 - Temp1;
                }
            }
            int result = Temp1;
            Console.WriteLine(result + " is GCF of" + Number1 + " and " + Number2);

        }
        // The While loop waws written using Temp1 and 2 so that the original values 
        // would remain the same so they could be output at the end with Temp1
    }
}
