using System;

namespace MyApplication

{
	class Program
	
	{
		static void Main(string[] args)
		
		{
		 string name = "John Doe";
		 int charPos = name.IndexOf("D");
		 string lastName = name.Substring(charPos);
		 
		 Console.WriteLine(lastName);	
		}
	}
}