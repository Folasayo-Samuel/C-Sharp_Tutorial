using System;

namespace MyApplication

{
	class UserInput
	
	{
		static void Main(string[] args)
		
		{
			Console.Write("Enter your name: ");
			string name = Console.ReadLine();
			Console.Write("Enter your age: ");
			string age = Console.ReadLine();
			Console.Write("Enter your sex: ");
			string sex = Console.ReadLine();
			Console.WriteLine("Hello " + name + " you are " + age + " years old, " + " and you are a " + sex );
			
			Console.ReadLine();
		}
	}
}