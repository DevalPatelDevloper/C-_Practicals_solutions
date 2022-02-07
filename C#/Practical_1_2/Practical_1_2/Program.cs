using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userResponse = Console.ReadLine();
            if (int.TryParse(userResponse,out int value))//using TryParse and solve error
            {
                Console.WriteLine("The entered value is a integer");
            }
            Console.ReadLine();
        }
    }
}
