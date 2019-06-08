using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgoritmStudy
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 3, 1, 5, 7, 9 };
            Sort Sort = new Sort();
            Sort.SelectionSort(array1);
            Console.ReadKey();
        }
    }

    public class Sort
    {
        private void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        private void Print(int[] a)
        {
            foreach (int i in a)
            {
                Console.Write(i);
            }
        }

        public void SelectionSort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int tmp = i;
                for (int j = i + 1; j < a.Length-1; j++)
                {
                    if (a[j] <= a[tmp])
                    {
                        tmp = j;
                    }
                }
                Swap(ref a[i], ref a[tmp]);
            }
            Print(a);
        }

        public void InsertionSort(int[] a)
        {

        }
    }
}
