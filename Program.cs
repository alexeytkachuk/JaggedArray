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
            int temp = 0; int tempMax = 0; int iMax = 0;
            int[][] sortedArray = new int[jaggedArray.Length][];

            for (int k = 0; k < jaggedArray.Length; k++)
            {
                for (int i = 0; i < jaggedArray.Length; i++)
                {
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        if (jaggedArray[i][j] > temp)
                        {
                            temp = jaggedArray[i][j];
                        }
                    }
                    if (tempMax < temp)
                    {
                        tempMax = temp;
                        iMax = i;
                    }
                    //Console.WriteLine(k);
                    //Console.WriteLine(iMax);
                    //Console.WriteLine(jaggedArray);
                   
                        sortedArray[k] = jaggedArray[iMax];
                    
                    
                   
                    
                }
            }
                    return sortedArray;
        }
    }
}
