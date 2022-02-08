using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_01_Cal
{
    class Program
    {
        static void Main(string[] args)
        {
            double no1, no2, sum, sub, mul, div;//variable declare
            Console.WriteLine("Enter Number 1: ");
            no1 = Convert.ToDouble(Console.ReadLine());//take input from user
            Console.WriteLine("Enter Number 2: ");
            no2 = Convert.ToDouble(Console.ReadLine());
            sum = no1 + no2;//adding two numbers
            sub = no1 - no2;//substraction two numbers
            mul = no1 * no2;//multiplication two numbers
            div = no1 / no2;//division two numbers
            //print ans of all operations
            Console.WriteLine("The sum of {0} and {1} is {2} .", no1, no2, sum);
            Console.WriteLine("The subtraction of {0} and {1} is {2} .", no1, no2, sub);
            Console.WriteLine("The multiplication of {0} and {1} is {2} .", no1, no2, mul);
            Console.WriteLine("The division of {0} and {1} is {2} .", no1, no2, div);
            Console.ReadKey();
        }
    }
}
