using System;

namespace MyApplcation

{
	class Program
	
	{
		static void Main(string[]args)
		
		{
			int myInt = 10;
			double myDouble = 5.25;
			bool myBool = true;
			
			Console.WriteLine(Convert.ToString(myInt)); //Convert to string
			Console.WriteLine(Convert.ToDouble(myInt));
			
			Console.WriteLine(Convert.ToInt32(myDouble));
			Console.WriteLine(Convert.ToString(myBool));
		}
	}
}