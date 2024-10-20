using System;

namespace Program
{
	class MainProgram
	{
		static void Main(string[] args)
		{
			int times = 10;
			Console.Write("0 1");
			FibonacciRecursion(0, 1, 0);
		}

		static void FibonacciLoop(int times)
		{
			int prevA = 0;
			int prevB = 1;
			int num = 0;

			Console.Write(prevA + " " + prevB);
			for(int i = 0; i < times; i++)
			{
				num = prevA + prevB;
				prevA = prevB;
				prevB = num;
				Console.Write(" " + num);
			}

			Console.WriteLine();
		}

		static void FibonacciRecursion(int prevA, int prevB, int times)
		{
			if(times < 10){
				int num = prevA + prevB;
				prevA = prevB;
				prevB = num;
				Console.Write(" " + num);
				times++;
				FibonacciRecursion(prevA, prevB, times);
			}

			else{
				return;
			}
		}

	}
}