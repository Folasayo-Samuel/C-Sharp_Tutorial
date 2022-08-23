using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gpaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter No of Courses: ");
            int TS = int.Parse(Console.ReadLine());
            Console.Write("Enter No of Classes: ");
            int TL = int.Parse(Console.ReadLine());
            string[] Subject = new string[TS];
            string[] Classes = new string[TL];
            double[] Marks = new double[TS + TL];
            double[] creditunits = new double[TS + TL];
            double[] TGPA = new double[TS + TL];

            for (int i = 0; i < TS; i++)
            {
                Console.Write("Enter Subject " + (i + 1) + " : ");
                Subject[i] = Console.ReadLine();
                Console.Write("Enter " + Subject[i] + " Marks: ");
                Marks[i] = double.Parse(Console.ReadLine());
                Console.Write("Enter " + Subject[i] + " Credit Units: ");
                creditunits[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < TL; i++)
            {
                Console.Write("Enter Class " + (i + 1) + " : ");
                Classes[i] = Console.ReadLine();
                Console.Write("Enter " + Classes[i] + " Classes Marks: ");
                Marks[i + TS] = double.Parse(Console.ReadLine());
                creditunits[i + TS] = 1;
            }

            for (int i = 0; i < (TS + TL); i++)
            {
                if (Marks[i] >= 70 && Marks[i] <= 100)
                {
                    TGPA[i] = 4 * creditunits[i];
                }
                else if (Marks[i] >= 60 && Marks[i] <= 69)
                {
                    TGPA[i] = 3.5 * creditunits[i];
                }
                else if (Marks[i] >= 50 && Marks[i] <= 59)
                {
                    TGPA[i] = 3.0 * creditunits[i];
                }
                else if (Marks[i] >= 45 && Marks[i] <= 50)
                {
                    TGPA[i] = 2.5 * creditunits[i];
                }
                else if (Marks[i] >= 0 && Marks[i] <= 44)
                {
                    TGPA[i] = 0.0 * creditunits[i];
                }
                else
                {
                  Console.WriteLine("RECORD NOT FOUND");
                }

            }
            double GPA = 0;
            double TC = 0;
            for (int i = 0; i < TS + TL; i++)
            {
                GPA = GPA + TGPA[i];
                TC = TC + creditunits[i];
            }
            double ClassGpa = GPA / TC;
            Console.WriteLine();
            Console.WriteLine("         **********         ");
            Console.WriteLine("Your Current GPA is: " + ClassGpa);
            Console.ReadLine();
        }
    }
}