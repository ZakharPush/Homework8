using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
           for (int i = array.Length; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
