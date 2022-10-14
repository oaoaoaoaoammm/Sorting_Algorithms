using System;

namespace Counting_sort
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void countingsort(int[] Array)
        {
            int n = Array.Length;
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                if (max < Array[i])
                {
                    max = Array[i];
                }
            }
            int[] freq = new int[max + 1];
            for (int i = 0; i < max + 1; i++)
            {
                freq[i] = 0;
            }
            for (int i = 0; i < n; i++)
            {
                freq[Array[i]]++;
            }
            for (int i = 0, j = 0; i <= max; i++)
            {
                while (freq[i] > 0)
                {
                    Array[j] = i;
                    j++;
                    freq[i]--;
                }
            }
        }
    }
}

