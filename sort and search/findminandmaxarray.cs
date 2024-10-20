using System;

namespace Array
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] data = {4, 2, 6, 10, 8};

			Console.WriteLine(Min(data) + " " + Max(data));
		}

		static int Min(int[] array)
		{
			int temp = array[0];

			for(int i = 0; i < array.Length; i++)
			{
				temp = (array[i] < temp) ? array[i] : temp;
			}

			return temp;
		}

		static int Max(int[] array)
		{
			int temp = array[0];

			for(int i = 0; i < array.Length; i++)
			{
				temp = (array[i] > temp) ? array[i] : temp;
			}

			return temp;
		}
	}
}