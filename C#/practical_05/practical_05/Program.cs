using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_05
{
    class Program
    {
        /// <summary>
        /// if we can arr[6] pass then error throw and Arr.length + 1 the error generate
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] Arr={12,11,10,11,2 };
            try
            {
                //Console.Write(Arr[6]);//error
                for (int i = 0; i < Arr.Length; i++)//Arr.Length+1 then error 
                {
                    Console.Write(Arr[i] + " ");
                }
            }catch(Exception ex)
            {
                Console.Write(ex);
            }
            finally//always run finally block
            {
                Console.Write("\nfinally block");
            }
            Console.ReadLine();
        }
    }
}
