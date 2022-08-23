using System;

namespace MyMethod

{
	class UpAndLowMethod
	
	{
		static void Main(string[]args)
		
		{
			string phrase = "Giraffe Academy";
			Console.WriteLine(phrase.ToUpper());
			Console.WriteLine(phrase.ToLower());
			Console.WriteLine(phrase.Contains("Academy"));
			Console.WriteLine(phrase[3]);
			Console.WriteLine(phrase.IndexOf("Academy"));
			Console.WriteLine(phrase.IndexOf('a'));
			Console.WriteLine(phrase.IndexOf('w'));
			Console.WriteLine(phrase.Substring(8));
			Console.WriteLine(phrase.Substring(8, 4));
			
			Console.ReadLine();
		}
	}
}