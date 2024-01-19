using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arrayInput = Console.ReadLine();
            string[] array = arrayInput.Split(' ');
            int index = int.Parse(Console.ReadLine());
            string aux;

            for (int i = 0; i < array.Length - 1; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (float.Parse(array[i]) > float.Parse(array[j]))
                    {
                        aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }

            Console.WriteLine(array[index]);
        }
    }
}
