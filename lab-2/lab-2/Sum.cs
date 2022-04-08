using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2
{
    class Sum
    {
        public void Hesap(double[] arr)
        {
            for (int i = 0; i < 10; i++)
            {
                arr[i] = arr[i] * 0.1;

                Console.WriteLine($"{i}--indexsdeki reqem{arr[i]}");
            }
        }
        public void Arry(string[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]},");

            }
        }
    }
}
