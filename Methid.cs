using System;
using System.Linq;

namespace MyApplication
{
	class Program
	{
		static void MyMethod(string name= "Folasayo")
		{
			Console.WriteLine("I just got executed! " + name);
		}
		static void Main(string[] args)
		{
			MyMethod();
			MyMethod("I am new here");
			MyMethod("What's up dude?");
		}
	}
}