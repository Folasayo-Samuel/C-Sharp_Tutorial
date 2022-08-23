using System;

namespace MyApplication

{
	class Program
	
	{
		static void Main(string[] args)
		
		{
			int [] luckyNumbers = { 4, 8, 15, 16, 23, 42};
			string[] friends = new string[12];
			friends[0] = "Jim";
			friends[1] = "Kelly";
			friends[2] = "Sam";
			friends[3] = "Jackson";
			friends[4] = "Benjamin";
			friends[5] = "Saint";
			friends[6] = "Vandora";
			friends[7] = "Jane";
			friends[8] = "Rickson";
			friends[9] = "Anderson";
			friends[10] = "Ronald";
			Console.WriteLine(friends[0]);
			
			luckyNumbers[1] = 900;
			Console.WriteLine(luckyNumbers[1]);
			Console.ReadLine();
		}
	}
}