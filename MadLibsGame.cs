using System;

namespace MyApplication

{
	class MadLibsGame
	
	{
		static void Main(string[] args)
		
		{
			string color, pluralNoun, celebrity;
			
			Console.Write("Enter a color: ");
			color = Console.ReadLine();
			Console.Write("Enter a Plural Noun: ");
			pluralNoun = Console.ReadLine();
			Console.Write("Enter a celebrity name: ");
			celebrity = Console.ReadLine();
			Console.WriteLine("Roses are " + color);
			Console.WriteLine(pluralNoun + " are blue");
			Console.WriteLine("I love " + celebrity);
		}
	}
}