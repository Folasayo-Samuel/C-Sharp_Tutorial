using System;
using System.Linq;

namespace MyApplication
{
	class Car
	{
		string color = "red";
		
		
		static void Main(string[] args)
		{
			Car myObj1 = new Car();
			Car myObj2 = new Car();
			Console.WriteLine(myObj1.color);
			Console.WriteLine(myObj2.color);
		}
	}
}