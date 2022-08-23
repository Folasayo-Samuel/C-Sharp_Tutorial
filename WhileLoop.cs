using System;

namespace MyApplication

{
	class Program
	
	{
		static void Main(string[]args)
		{
			int i = 0;
			while(i < 5)
			{
				Console.WriteLine(i);
				i++;
			}
			
			// Using Do/While Loop
			Console.WriteLine("----------------------------");
			int a =0;
			do
			{
				Console.WriteLine(a);
				a++;
			} 
			while(a < 5);
		}
	}
}