using System;

namespace Cocktail_sort
{
    class Program
    {
        static void Main(string[] args)
        {
        }
		public static void CocktailSort(ref int[] arr)
		{
			while (true)
			{
				bool flag;
				int[] start = { 1, arr.Length - 1 };
				int[] end = { arr.Length, 0 };
				int[] inc = { 1, -1 };

				for (int a = 0; a < 2; ++a)
				{
					flag = true;
					for (int i = start[a]; i != end[a]; i += inc[a])
					{
						if (arr[i - 1] > arr[i])
						{
							Swap(ref arr[i - 1], ref arr[i]);
							flag = false;
						}
					}
					if (flag)
						return;
				}
			}
		}
		private static void Swap(ref int a, ref int b)
		{
			a ^= b;
			b ^= a;
			a ^= b;
		}
	}
}
