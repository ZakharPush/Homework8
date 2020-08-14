using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8_task5
{
    class Program
    {
        public static void IncreaseArray(int[] array)
        {
            int[] newArray = new int[array.Length+1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
        public static void Add(ref int[] array, int value)
        {
            int[] newArrayAdd = new int[array.Length + 1];
            newArrayAdd[0] = value;
            for (int i = 0; i < array.Length; i++)
            {
                newArrayAdd[i + 1] = array[i];
            }
            array = newArrayAdd;
        }
        static void Main(string[] args)
        {
            int[] MyArray = { 3, 5, 9 };
            IncreaseArray(MyArray);

            int[] MyArrayAdd = { 1, 9, 7 };
            Add(ref MyArrayAdd, 4);
            Console.ReadKey();
        }
    }
}
