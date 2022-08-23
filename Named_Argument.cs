using System;
using System.Linq;

namespace MyApplication
{
	class Program
	{
		static void MyMethod(string child1, string child2, string child3)
		{
			Console.WriteLine("The youngest child is: " + child3);
		}
		
		static void Main(string[] args)
		{
			MyMethod(child3: "John", child2: "Liam", child1: "Sam");
		}
	}
}