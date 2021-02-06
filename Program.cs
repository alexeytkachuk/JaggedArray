using System;
using System.Collections.Generic;
using System.Linq;

namespace JaggedArray
{
    public class Program
    {

        static int GetSumForArray(int[][] newArray, int rowIndex)
        {

            int sum = 0;
            foreach (var item in newArray[rowIndex])
            {
                sum += item;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomer = rnd.Next(3, 10);

            int[][] jaggedArray = new int[randomer][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new int[rnd.Next(1, 10)];
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = rnd.Next(0, 10);
                }
            }
            PrintArray(jaggedArray);
            var item = SortArray(jaggedArray);
            PrintArray(item);
        }

        static void PrintArray(int[][] array)
        {
            Console.WriteLine("JaggedArray:");

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.Write("sum = {0}", GetSumForArray(array, i));
                Console.WriteLine();
            }
            Console.WriteLine("");
        }

        static int GetRowIndex(int length)
        {
            int rowIndex;
            Console.WriteLine("Choose row of array");
            while ((!int.TryParse(Console.ReadLine(), out rowIndex)) || (rowIndex > length))
            {
                Console.Write("Error! Enter number of row\n");
            }
            return rowIndex - 1;
        }
        static int[][] SortArray(int[][] jaggedArray)
        {
            var item = new Dictionary<int, int>();

            for (int i=0; i < jaggedArray.Length; i++) 
            {
                item.Add(i, GetMaxValueFromRow(jaggedArray[i]));
            }
            var arrayOfArray = new List<int[]>();
            foreach (var temp in item.OrderByDescending(ValueSelector))
            {
                arrayOfArray.Add(jaggedArray[temp.Key]);
            }
            return arrayOfArray.ToArray();
        }

        public static int ValueSelector(KeyValuePair<int, int> item)
        {
            return item.Value;
        }
        public static int GetMaxValueFromRow (int[] line)
        {
            var maxNumberInRow = 0;
            for (int j = 0; j < line.Length; j++)
            {
                if (line[j] > maxNumberInRow)
                {
                    maxNumberInRow = line[j];
                }
            }
           
            return maxNumberInRow;
        }
    }
}
