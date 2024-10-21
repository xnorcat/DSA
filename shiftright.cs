using System;

namespace ShiftRightiIG
{
	class Program
	{
		static int[] shiftFront(int dataToInsert, int[] array)
		{
			int tempA = array[0], tempB = array[1];
			array[0] = dataToInsert;
			
			for(int i = 1; i < array.Length; i++)
			{
				array[i] = tempA;
				tempA = tempB;
				tempB = ((i+1) >= array.Length) ? 0 : array[i+1];
			}
			return array;
		}
		
		static void Main(string[] args)
		{
			int[] place = {1, 2, 3, 4, 5};
			int data = place[4];
			
			foreach (var element in place) {
				Console.Write(element + " ");
			}
			Console.WriteLine();
			
			place = shiftFront(data, place);
			
			foreach (var element in place) {
				Console.Write(element + " ");
			}
			Console.WriteLine();
			Console.ReadKey();
			
		}
	}	
}