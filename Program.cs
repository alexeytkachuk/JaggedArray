using System;

namespace JaggedArray
{
    class Program
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
            var resultArray = SortArray(jaggedArray);
            PrintArray(resultArray);
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
            int[] maxValuesFromArray = new int[jaggedArray.Length];
            for (int k = 0; k < jaggedArray.Length; k++)
            {
                // Search the MaxValue in the matrix
                int maxRowValue = 0;
                // Search maxValue in the row
                for (int j = 0; j < jaggedArray[k].Length; j++)
                {
                    if (jaggedArray[k][j] > maxRowValue)
                    {
                        maxRowValue = jaggedArray[k][j];
                    }
                }
                maxValuesFromArray[k] = maxRowValue;
            }
           
            int temp = 0;
            int[] tempArray;
            for (int j = 0; j <= maxValuesFromArray.Length - 2; j++)
            {
                for (int i = 0; i <= maxValuesFromArray.Length - 2; i++)
                {
                    if (maxValuesFromArray[i] < maxValuesFromArray[i + 1])
                    {
                        temp = maxValuesFromArray[i + 1];
                        maxValuesFromArray[i + 1] = maxValuesFromArray[i];
                        maxValuesFromArray[i] = temp;

                        tempArray = jaggedArray[i + 1];
                        jaggedArray[i + 1] = jaggedArray[i];
                        jaggedArray[i] = tempArray;
                    }
                }
            }
            return jaggedArray;
        }
    }
}
