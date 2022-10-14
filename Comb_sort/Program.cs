using System;

namespace Comb_sort
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class CombSort
    {
        static int updatedGap(int gap)
        { 
            gap = (gap * 10) / 13;
            if (gap < 1)
                return 1;
            return gap;
        }
        static void combSort(int[] a, int n)
        {
            int gap = n;
            int swapped = 1;
            while (gap != 1 || swapped == 1)
            {
                gap = updatedGap(gap);
                swapped = 0;
                for (int i = 0; i < n - gap; i++)
                {
                    if (a[i] > a[i + gap])
                    {
                        int temp = a[i];
                        a[i] = a[i + gap];
                        a[i + gap] = temp;
                        swapped = 1;
                    }
                }
            }
        }
    }
}
