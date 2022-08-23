using System;

namespace MyApplication

{
	class Program
	{
		static void Main(string[]args)
		{
			// Using a for loop
			string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
			for(int i=0; i<cars.Length; i++)
			
			{
				Console.WriteLine(cars[i]);
			}
			
			// Using foreach loop
			// This is are used to perform thesame task as for loop.
			
			string[] carss = {"Volvo", "BMW", "Ford", "Mazda"};
			foreach(string i in carss)
			{
				Console.WriteLine(i);
			}
			
			// Sort a string
			string[] carses = {"Volvo", "BMW", "Ford", "Mazda"};
			Array.Sort(carses);
			foreach (string i in carses)
			{
				Console.WriteLine(i);
			}
			
			// Sort an integer
			int[] myNumbers = {5, 1, 8, 9};
			Array.Sort(myNumbers);
			foreach(int i in myNumbers)
			{
				Console.WriteLine(i);
			}
		}
	}
}