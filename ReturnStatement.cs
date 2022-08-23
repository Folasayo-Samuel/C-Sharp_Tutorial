using System;

namespace MyApplication

{
	class Program
	
	{
		static void Main(string[]args)
		
		{
			Console.WriteLine(cube(5));
			 // Same thing using different methods to achieve the same result.
			 int cubedNumber = cube(5);
			 Console.WriteLine(cubedNumber);
			
			Console.ReadLine();
		}
		static int cube(int num)
		{
			int result = num * num * num;
			return result;
		}
	}
}