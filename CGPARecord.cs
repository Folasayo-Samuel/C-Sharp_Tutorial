using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentCGPARecord

{
	class Program
	
	{
		static void Main(string[] args)
		
		{
			Console.WriteLine("Welcome to Kwara State University Department of Computer Science");
			Console.WriteLine("GPA Calculator");
			Console.WriteLine("How many students are there in your Level?");
			
			int students = Convert.ToInt32(Console.ReadLine());
			
			string[,] marksheet = new string[students + 1, 9];
			
			int[] creditunits = new int[6];
			
			double[,] gradepoint = new double[students,6];
			double[] gradepointaverage = new double[students];
			
			for(int i = 0; i < students + 1; i++)
			
			{
				for(int j = 0; j < 9; j++)
				
				{
					if(i == 0 && j == 0)
					
					{
						marksheet[i, j] = "";
					} else if(i==0) 
					{
						Console.WriteLine("Please Enter Name of Course {0}", j);
						
						marksheet[i, j] = Console.ReadLine();
						Console.WriteLine("Please Enter the number of CREDIT UNIT(S) of {0}", marksheet[i,j]);
						creditunits[i, j] = Convert.ToInt32(Console.ReadLine());
					} else if(j==0)
					
					{
						Console.WriteLine("\nPlease Enter the Name of Student Number {0}",i);
						marksheet[i,j] = Console.ReadLine();
					} else if(i!=0 && j!=0)
					{
						Console.WriteLine("Please enter marks (out of 100) of {0} in the subject {1}:", marksheet[i, 0], marksheet[0, j]);
						marksheet[i,j] = Console.ReadLine();
						
						int marks = Convert.ToInt32(marksheet[i,j]);
						if(marks >= 70)
						
						{
							gradepoint[i-1, j-1] = 4.0;
						} else if(marks >= 60 && marks < 70)
						{
							gradepoint[i-1, j-1] = 3.5;
						} else if(marks >= 50 && marks < 60)
						{
							gradepoint[i-1, j-1] = 3.0;
						}else if(marks >= 45 && marks < 50)
						{
							gradepoint[i-1, j-1] = 2.0;
						}else if(marks >= 0 && marks < 45)
						{
							gradepoint[i-1, j-1] = 0.0;
						}
					}
				}
				Console.Clear();
			}
			
			double[] GradePointProduct = new double[6];
			double sumgpa = 0;
			int sumcreditunits = 0;
			for(int i = 0; i < students; i++)
			{
				for(int j = 0; j < 6; j++)
				{
					GradePointProduct[j] = gradepoint[i,j] * creditunits[j];
					sumcreditunits += creditunits[j];
					sumgpa += GradePointProduct[j];
				}
				gradepointaverage[i] = sumgpa / sumcreditunits;
			}
			for(int i = 0; i < students; i++)
			{
				Console.WriteLine(" MARKSHEET");
				Console.WriteLine("STUDENT NAME: {0}\n\n", marksheet[i+1, 0]);
				Console.WriteLine("COURSE TITLE\t\tMARKS OBTAINED\t\tGRADE POINT\n");
				for(int j=1; j<7; j++)
				{
					Console.WriteLine("{0}\t\t{1}\t\t{2}\n", marksheet[0,j], marksheet[i+1, j], gradepoint[i, j-1]);
				}
				Console.WriteLine("GRADE POINT AVERAGE: {0}", gradepointaverage[i]);
			}
		}
	}
}