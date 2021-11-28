using System;

namespace Gnome_sort
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static int[] Gnome(int[] unsortedArray)
        {
            var index = 1;
            var nextIndex = index + 1;
            while (index < unsortedArray.Length)
            {
                if (unsortedArray[index - 1] < unsortedArray[index])
                {
                    index = nextIndex;
                    nextIndex++;
                }
                else
                {
                    Swap(ref unsortedArray[index - 1], ref unsortedArray[index]);
                    index--;
                    if (index == 0)
                    {
                        index = nextIndex;
                        nextIndex++;
                    }
                }
            }
            return unsortedArray;
        }
        private static void Swap(ref int a, ref int b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }
    }
}
