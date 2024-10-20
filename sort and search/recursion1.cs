using System;

namespace Program
{
	class Recursion
	{
		static void Main(string[] args)
		{
			int num = 100;
			Subtraction(num);
		}

		static void Subtraction(int num)
		{
			if(num == 0){
				return;
			}
			Console.Write(num + " ");
			Subtraction(num - 1);
		}
	}
}