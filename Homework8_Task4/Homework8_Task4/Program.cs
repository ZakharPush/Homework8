using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8_Task4
{
    class Program
    {
        static int[] MyReverse(int[] array)
        {
            for (int i = array.Length; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            return array;
        }
        static int[] SubArray(int[] array, int index, int count)
        {
            for (int i = 0; i <= array.Length; i++)
            {
                if (i >= index && i <= count)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();

            int[] newArray = new int[count];
            for (int i = 0; i < array.Length; i++)
            {
                if (count > index && count <= array.Length)
                {
                    array[i] = newArray[i];
                    newArray[i] = 1;
                    Console.WriteLine(newArray[i]);
                }
            }
            array = newArray;
            return array;
        }
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            int[] arr = MyReverse(myArray);
            Console.WriteLine();

            Console.Write("Введіть index : ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть count : ");
            int count = Convert.ToInt32(Console.ReadLine());

            int[] myArrayCount = new int[count];
            int[] arrCount = SubArray(myArrayCount, index, count);

            Console.ReadKey();
        }
    }
}
