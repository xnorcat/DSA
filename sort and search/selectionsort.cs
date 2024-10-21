using System;

namespace Sort
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] data = {9, 2, 5, 1, 4};

			data = SelectionSortSwap(data);


			// foreach(var number in data){
			// 	Console.Write(number + " ");
			// }
		}

		static int[] SelectionSortSwap(int[] data)
		{
			bool swap = false;
			for(int j = 0; j < data.Length - 1; j++)
			{
				int selectIndex = j;

				for(int i = j; i < data.Length - 1; i++)
				{
					selectIndex = (data[selectIndex] > data[i+1]) ? i+1 : selectIndex;
				}

				int tempA = data[j]; //Get the front value
				data[j] = data[selectIndex];
				data[selectIndex] = tempA;

				foreach(var number in data){
					Console.Write(number + " ");
				}
				Console.WriteLine();
			}
			
			return data;
		}

		static int[] SelectionSortShift(int[] data)
		{
			
		}
	}
}