// The void keyword, used in other examples, indicates that the method should not return a value. If you want the method to return a value, you can use a primitive data type (such as int or double) instead of void, and use the return keyword inside the method.
using System;
using System.Linq;

namespace MyApplication
{
	class Program
	{
		static int MyMethod(int x, int y)
		{
			return 5 + x + y;
		}
		
		static void Main(string[] args)
		{
			int z = MyMethod(3, 4);
			Console.WriteLine(z);
			
			// Console.WriteLine(MyMethod(3, 4));
		}
	}
}