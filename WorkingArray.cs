using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal static class WorkingArray
    {
        public static void ArrayMake(int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(-100, 100);
            }
        }
        public static void BubbleSorting(int[] a)
        {
            for (int j = 0; j < a.Length - 1; j++)
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        int k = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = k;
                    }
                }
            }
        }
       public static int MaxElement(int[] a)
        {
            int max = a[0];
            int imax = 0;
            for (int i = 1; i <= a.Length - 1; i++)
            {
                if (a[i] > max)
                {
                    max= a[i]; 
                    imax = i;
                }
            }
            return imax;
        }
        public static int MinElement(int[] a)
        {
            int min = a[0];
            int imin = 0;
            for (int i = 1; i <= a.Length - 1; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    imin = i;
                }
            }
            return imin;
        }
        public static double Average(int[] a)
        {
            int sum = 0;
            int len = a.Length;
            for (int i = 0; i < len; i++)
            {
                sum += a[i];
            }
            return (double) sum / len;
        }
    }
}
