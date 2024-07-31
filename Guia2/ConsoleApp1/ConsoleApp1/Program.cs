using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // Generar una lista de 20 números aleatorios menores de 100
            Random random = new Random();
            int[] numbers = new int[20];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100);
            }

            // Mostrar la lista original
            Console.WriteLine("Lista original:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Ordenar la lista utilizando el método de la burbuja
            BubbleSort(numbers);

            // Mostrar la lista ordenada
            Console.WriteLine("Lista ordenada:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }

        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < n - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        // Intercambiar los elementos
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }
                n--; // Optimización: No es necesario comparar hasta el final de la lista en cada pasada
            } while (swapped);
        }
    }
}
