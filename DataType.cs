using System;

namespace DataTypes

{
	class VarTypes
	
	{
		static void Main(string[] args)
		
		{
			string phrase = "Giraffe Academy";
			char grade = 'A';
			int age = 30;
			// We can store our decimal datatypes with any of these three datatypes: float, double or decimal
			double GPA = 3.3;
			bool isMale = true;
			Console.WriteLine("Hello, my name is " + phrase + ", my grade is " + grade + ", I am " + age + "years old " + "with CGPA of " + GPA + "I'm a " + isMale);
			
			Console.ReadLine();
		}
	}
}