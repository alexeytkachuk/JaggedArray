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

            //int rowIndex = GetRowIndex(jaggedArray.Length);
            //Console.WriteLine("Array:{0}\nSum all elements of array is: {1}", string.Join(" ", jaggedArray[rowIndex]), GetSumForArray(jaggedArray, rowIndex));

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
              
            int[][] sortedArray = new int[jaggedArray.Length][];

            for (int k = 0; k < jaggedArray.Length; k++)
            {
                int maxMatrixValue = 0;
                int maxRowIndex = 0;
                // Search the MaxValue in the matrix
                for (int i = 0; i < jaggedArray.Length; i++)
                {
                    int maxRowValue = 0;
                    // Search of maxValue in the row
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {

                        if (jaggedArray[i][j] > maxRowValue)
                        {
                            maxRowValue = jaggedArray[i][j];
                        }
                    }
                    if (maxMatrixValue < maxRowValue)
                    {
                        maxMatrixValue = maxRowValue;
                        maxRowIndex = i;
                    }

                }
                sortedArray[k] = jaggedArray[maxRowIndex];
            }
                    return sortedArray;
        }
    }
}
