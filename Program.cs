using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        int[] a = new int[10];

        public void generateArray()
        {
            Random r = new Random();
                for (int i = 0; i < a.Length; i++)
                {
                a[i] =(int) (r.NextDouble() * 25);
                }
        }

        public void printArray()
        {
            for (int i = 0; i < a.Length; i++)
            {
               Console.Write( a[i] + "  " );
            }

        }

        public void bubbleSortUp()
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[i] > a[j]) {
                        int dop = a[i];
                        a[i] = a[j];
                        a[j] = dop;
                    }
                }
            }
        }

        public void bubbleSortDown()
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int dop = a[i];
                        a[i] = a[j];
                        a[j] = dop;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Программа пузырьковой сортировки");
            Console.WriteLine();
            Program Sort = new Program();
            Sort.generateArray();
            Console.WriteLine("Исходный массив:");
            Sort.printArray();
            Console.WriteLine();
            Sort.bubbleSortUp();
            Console.WriteLine("Массив после сортировки по возрастанию:");
            Sort.printArray();
            Console.WriteLine();
            Sort.bubbleSortDown();
            Console.WriteLine("Массив после сортировки по убыванию:");
            Sort.printArray();
            Console.ReadLine();
        }
    }
}
