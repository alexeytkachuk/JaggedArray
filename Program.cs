using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Реализовать метод подсчета суммы всех элементов обычного array
//Реализовать метод подсчета суммы определенной строки jagged array

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[5][];
            jaggedArray[0] = new int[7];
            jaggedArray[1] = new int[9];
            jaggedArray[2] = new int[13];
            jaggedArray[3] = new int[15];
            jaggedArray[4] = new int[17];

            Random rnd = new Random();

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = rnd.Next(0, 10);
                }
            }

             int GetSumForArray(int howString)
            {

                int sum = 0;
                foreach (var item in jaggedArray[howString])
                {
                    sum += item;
                }
                return sum;
            }

            Console.WriteLine("Change string of array");
            int stringOfArray = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Array:{0}\nSum all elements of array is: {1}", string.Join(" ", jaggedArray[stringOfArray]), GetSumForArray(stringOfArray));
        }
       
    }
}
