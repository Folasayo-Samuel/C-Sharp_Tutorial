using System;

namespace Giraffe

{
	class Program
	
	{
		static void Main(string[]args)
		
		{
			SayHi("Mike ", 33);
			SayHi("Tom ", 24);
			SayHi("Yike ", 25);
			
			Console.ReadLine();
		}
		
		static void SayHi(string name, int age) 
		{
			Console.WriteLine("Hello " + name + age);
		}
	}
}