using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstArrayInput = Console.ReadLine();
            string[] firstArray = firstArrayInput.Split(' ');
            string secondArrayInput = Console.ReadLine();
            string[] secondArray = secondArrayInput.Split(' ');

            int m = firstArray.Length;
            int n = secondArray.Length;
            int i = 0, j = 0, k = -1;

            string[] thirdArray = new string[m + n];

            while (i < m && j < n)
            {
                if (float.Parse(firstArray[i]) <= float.Parse(secondArray[j]))
                {
                    thirdArray[++k] = firstArray[i];
                    i += 1;
                }
                else
                {
                    thirdArray[++k] = secondArray[j];
                    j += 1;
                }
            }

            while (i < m)
            {
                thirdArray[++k] = firstArray[i];
                i += 1;
            }

            while (j < n)
            {
                thirdArray[++k] = secondArray[j];
                j += 1;
            }

            for (int a = 0; a < thirdArray.Length; a++)
            {
                Console.Write(thirdArray[a] + " ");
            }
            Console.Write('\n');
        }
    }
}
