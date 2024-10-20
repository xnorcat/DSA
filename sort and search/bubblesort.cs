using System;

namespace Sort
{
	class MainProgram
	{
		static void Main(string[] args)
		{
			int[] data = {3, 1, 4, 5, 6};

			data = BubbleSort(data);
			foreach(var number in data)
			{
				Console.Write(number + " ");
			}

			Console.WriteLine();
		}

		static int[] BubbleSort(int[] data)
		{
			int temp = 0;

			for(int i = data.Length; i > 0; i--)
			{
				for(int j = 0; j < i - 1; j++)
				{
					if(data[j] > data[j+1])
					{
						temp = data[j+1];
						data[j+1] = data[j];
						data[j] = temp;
					}
				}
		}	

			return data;
		}
	}
}