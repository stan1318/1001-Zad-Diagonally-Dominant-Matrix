using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1001_Zad_Diagonally_Dominant_Matrix
{
    class Program
    {
        static void printArray(int [,]array,int size){
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(array[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {int size=new int();
        do
        {
            Console.Write("Please input the size of the Matrix with a maximum of 10    (11 for info): ");
            size = Convert.ToInt32(Console.ReadLine());
            if (size == 11) { Console.WriteLine("The matrix you enter will be converted into A Diagonally Dominant Matrix! It is a matrix that each member of the main diagonal is bigger or equal to the sum of the other members on the row...also all the numbers are in their absolute value(not negative)"); }
        }
        while (size < 0 || size > 10);
            Console.WriteLine("Please type in the numbers of the array for each row divided by a space: "+Environment.NewLine);
            int [,] array=new int[size,size];
            string[] arrstr = new string[size];
            for (int i = 0; i < size; i++)
            {
                arrstr = Console.ReadLine().Split();
                for (int j = 0; j < size; j++)
                {
                    array[i, j] = System.Math.Abs(Convert.ToInt32(arrstr[j]));
                }
            }
            int sum = 0;
         for(int i=0;i<size;i++)
         {
            for(int j=0;j<size;j++)
            {
                sum = sum + array[i, j];
            }
            int temp = array[i, i];
            while (sum-temp > array[i, i])
            {
               array[i, i]++;
            }
            sum = 0;
            }
         Console.WriteLine();
         printArray(array, size);
         Console.ReadLine();
        }
    }
}
