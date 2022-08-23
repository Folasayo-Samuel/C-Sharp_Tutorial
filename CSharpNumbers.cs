using System;

namespace CSharpNumbers

{
	class CNumbers
	
	{
		static void Main(string[]args)
		
		
		{
			Console.WriteLine(5 + 8);
			Console.WriteLine(5 - 8);
			Console.WriteLine(5 * 8);
			Console.WriteLine(5 / 8);
			Console.WriteLine(2 ^ 2);
			Console.WriteLine(4 % 2);
			Console.WriteLine(2 + 2 * 3);
			Console.WriteLine( (2 + 2) * 3);
			Console.WriteLine("String\nSpace");
			
			int myNum = 8;
			myNum++; // It will add one to the number making 9.
			myNum--; // Then, subtracting by one number printing 8 as the final answer.
			Console.WriteLine(myNum);
			
			// Examples of Math() Method
			Console.WriteLine(Math.Abs(-40)); // This is Math Absolute Method.
			Console.WriteLine(Math.Pow(2, 2)); // This is Math Raise To Power Method.
			Console.WriteLine(Math.Pow(2, 2.4)); // This is Raise To Power Using Decimal.
			Console.WriteLine(Math.Sqrt(9)); // This is a Math Square Root Method.
			Console.WriteLine(Math.Max(4, 90)); // This Math Max Method check the biggest number in the method.
			Console.WriteLine(Math.Min(4, 90)); // This Math Min Method returns the smallest integer in the method.
			Console.WriteLine(Math.Round(4.5)); // This Math Round Method round up decimal integer to whole integer.
			Console.WriteLine(Math.Round(4.6)); // This will approximate the integer to 5 whole number.
		}
	}
}
