using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Coding_Assesment_07._10._22
{
    internal class Question6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal number");
            int deci = int.Parse(Console.ReadLine());
            int temp = deci;
            int length = 32;
            int[] arr = new int[length];
            int count = 0;
            while (temp >= 0 && count < length)
            {
                if (temp % 2 == 1)
                {
                    arr[count] = 1;
                    temp = temp / 2;
                }
                else
                {
                    arr[count] = 0;
                    temp = temp / 2;
                }
                count++;
            }
            for (int i = length -1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
            Console.Write("\n");
            
        }
    }
}
