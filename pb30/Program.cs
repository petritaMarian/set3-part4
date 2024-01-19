using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstArrayInput = Console.ReadLine();
            string[] firstArray = firstArrayInput.Split(' ');
            string secondArrayInput = Console.ReadLine();
            string[] secondArray = secondArrayInput.Split(' ');
            string aux;

            for (int i = 0; i < firstArray.Length - 1; i++)
                for (int j = i + 1; j < firstArray.Length; j++)
                {
                    if (int.Parse(firstArray[i]) > int.Parse(firstArray[j]))
                    {
                        aux = firstArray[i];
                        firstArray[i] = firstArray[j];
                        firstArray[j] = aux;
                        aux = secondArray[i];
                        secondArray[i] = secondArray[j];
                        secondArray[j] = aux;
                    }
                    else if (int.Parse(firstArray[i]) == int.Parse(firstArray[j]))
                        if (int.Parse(secondArray[i]) < int.Parse(secondArray[j]))
                        {
                            aux = firstArray[i];
                            firstArray[i] = firstArray[j];
                            firstArray[j] = aux;
                            aux = secondArray[i];
                            secondArray[i] = secondArray[j];
                            secondArray[j] = aux;
                        }
                }
            for (int i = 0; i < firstArray.Length; i++)
                Console.Write(firstArray[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < secondArray.Length; i++)
                Console.Write(secondArray[i] + " ");
        }
    }
}
