using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arrayInput = Console.ReadLine();
            string[] array = arrayInput.Split(' ');
            int[] numArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
                numArray[i] = int.Parse(array[i]);

            QuickSort(numArray, 0, array.Length - 1);

            for(int i = 0; i < numArray.Length; i++)
                Console.Write(numArray[i] + " ");
        }

        static int[] QuickSort(int[] array, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = array[left];

            while (i <= j)
            {
                while (array[i] < pivot)
                    i += 1;

                while (array[j] > pivot)
                    j -= 1;

                if (i <= j)
                {
                    int aux = array[i];
                    array[i] = array[j];
                    array[j] = aux;
                    i += 1;
                    j -= 1;
                }
            }

            if (left < j)
                QuickSort(array, left, j);

            if (i < right)
                QuickSort(array, i, right);

            return array;
        }
    }
}
