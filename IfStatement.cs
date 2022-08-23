using System;

namespace MyApplication
{
	class Program
	
	{
		static void Main(string[]args)
		{
			bool isMale = true;
			bool isTall = true;
			
			if(isMale && isTall)
			{
			  Console.WriteLine("You are a Tall male!");	
			}else if(isMale && !isTall)
			{
				Console.WriteLine("You are not a Tall male!");
			} else if(!isMale && isTall)
			{
				Console.WriteLine("You are not a male, but you are Tall!");
			}
			else
			{
				Console.WriteLine("You are not a Tall male!");
			}
			
			Console.ReadLine();
		}
	}
}