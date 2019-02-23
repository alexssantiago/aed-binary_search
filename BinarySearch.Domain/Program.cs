using System;
using System.Linq;

namespace BinarySearch.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[9] { 8, 4, 15, 23, 42, 16, 57, 92, 61 };

            Console.Write("Array informado: ");
            PrintArray(values);

            Binary bs = new Binary(values);
            Console.Write("\nArray ordenado: ");
            PrintArray(values);

            int busca = 61;

            Console.WriteLine($"\nItem '{busca}' encontrado na posição '{bs.Search(values, v: busca, first: 0, last: values.Length - 1)}'.");

            Console.ReadKey();
        }

        private static void PrintArray(int[] values)
        {
            Console.Write("{");
            values.ToList().ForEach(i => Console.Write($" {i} "));
            Console.Write("}");
        }
    }
}
