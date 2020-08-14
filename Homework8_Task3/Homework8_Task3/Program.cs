using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double sum = 0;
            double avgsum = 0;
            Console.Write("Введіть величину масиву : ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraySize];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введіть елемент масиву : ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Масив : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            int maxVal = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxVal)
                {
                    maxVal = array[i];
                }
            }
            Console.WriteLine("\nМаксимальне значення масиву : {0} ", maxVal);
            
            int minVal = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minVal)
                {
                    minVal = array[i];
                }
            }
            Console.WriteLine("\nМінімальне значення масиву : {0} ", minVal);

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("\nСума елементів масиву : {0} ", sum);

            for (int i = 0; i < array.Length; i++)
            {
                avgsum = sum /(double)(arraySize);
            }
            Console.WriteLine("\nСереднє арифметичне елементів масиву : {0} ", avgsum);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.WriteLine("Непарні числа : {0} ", array[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
