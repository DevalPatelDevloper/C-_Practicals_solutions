using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Options
{
        Aggregate = 1,
        MinMark = 2,
        MaximumMark = 3,
        Grade = 4
};
namespace practical_04
{
    class Student
    {
        public string Name;
        public decimal[] Marks=new decimal[5];
        public static decimal AverageMarks;

        public decimal CalculateAverageMarks()
        {
            decimal Result =0;
            foreach(int items in Marks)
            {
                Result += items;
            }
            AverageMarks =Result/Marks.Length;
            return AverageMarks;
        }
       public string  CalculateGrade()
       {
            decimal per=0;
            string Grade="No Grade";
            for(int i=0 ;i<Marks.Length;i++)
            {
                per += Marks[i];
            }
            per = (per/(Marks.Length));
            if(per > 90)
               Grade="A Grade";
            else if(per > 80)
               Grade="B Grade";
            else if(per > 70)
               Grade="C Grade";
            else if(per < 90)
               Grade="D Grade";
            return Grade;
       }
    }
    
     /// <summary>
     /// create array and take input as a mark and using switch case 4 diff operation perform
     /// </summary>
     /// <param name="args"></param>
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine("Enter Name:");
            String nm = Console.ReadLine();
            for(int i=0;i<s1.Marks.Length;i++)
            {
                Console.WriteLine("Enter Mark:");
                s1.Marks[i]=decimal.Parse(Console.ReadLine());
            }
            while(true)
            {

                Console.WriteLine("1. Aggerate");
                Console.WriteLine("2. MinMark");
                Console.WriteLine("3. MaximumMark");
                Console.WriteLine("4. Grade");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter Choice:");
                int ch = int.Parse(Console.ReadLine());
                switch(ch) 
                {
                  case (int)Options.Aggregate:
                        Console.WriteLine($"Name is {s1.Name} and Average is {s1.CalculateAverageMarks()}");
                        Console.ReadLine();
                    break;
                  case (int)Options.MinMark:
                        Console.WriteLine($"Min Mark: {s1.Marks.Min()}");
                        Console.ReadLine();
                    break;
                  case (int)Options.MaximumMark:
                        Console.WriteLine($"Max Mark:{s1.Marks.Max()}");
                        Console.ReadLine();
                    break;
                  case (int)Options.Grade:
                        Console.WriteLine($"Grade is:{s1.CalculateGrade()}");
                        Console.ReadLine();
                    break;
                  case 5:
                        return;
                        Console.ReadLine();
                    break;
                  default:
                        Console.WriteLine("wrong input");
                        Console.ReadLine();
                    break;
                }
            }
        }
    }
}
