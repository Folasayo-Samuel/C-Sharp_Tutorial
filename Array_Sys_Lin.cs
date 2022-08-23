using System;
using System.Linq;

namespace MyApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] myNumbers = {5, 1, 8, 9};
			Console.WriteLine(myNumbers.Max()); //This will return the largest value
			Console.WriteLine(myNumbers.Min()); // returns the min value
			Console.WriteLine(myNumbers.Sum()); //returns the sum of the elements.
			
			
		}
	}
}