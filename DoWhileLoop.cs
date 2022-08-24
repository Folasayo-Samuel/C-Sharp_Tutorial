using System;
using System.Linq;

namespace MyApplication
{
	class WhileLoops
	{
		static void Main(string[] args)
		{
			int index = 8;
			do
			{
				Console.WriteLine(index);
				index++;
			}while(index <= 5);
		}
	}
}