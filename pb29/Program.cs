using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb29
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

            SortArray(numArray, 0, array.Length - 1);

            for (int i = 0; i < numArray.Length; i++)
                Console.Write(numArray[i] + " ");
        }

        static int[] SortArray(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                SortArray(array, left, middle);
                SortArray(array, middle + 1, right);

                MergeArray(array, left, middle, right);
            }

            return array;
        }

        static void MergeArray(int[] array, int left, int middle, int right)
        {
            int n = middle - left + 1;
            int m = right - middle;
            int[] leftAux = new int[n];
            int[] rightAux = new int[m];
            int i, j;

            for (i = 0; i < n; i += 1)
                leftAux[i] = array[left + i];
            for (j = 0; j < m; j += 1)
                rightAux[j] = array[middle + 1 + j];

            i = 0;
            j = 0;
            int k = left - 1;

            while (i < n && j < m)
            {
                if (leftAux[i] <= rightAux[j])
                {
                    array[++k] = leftAux[i];
                    i += 1;
                }
                else
                {
                    array[++k] = rightAux[j];
                    j += 1;
                }
            }

            while (i < n)
            {
                array[++k] = leftAux[i];
                i += 1;
            }

            while (j < m)
            {
                array[++k] = rightAux[j];
                j += 1;
            }
        }
    }
}
