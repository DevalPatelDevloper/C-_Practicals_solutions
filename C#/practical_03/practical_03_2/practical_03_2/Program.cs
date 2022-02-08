using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_03_2
{
    //create bird class
        class Bird
        {
            public virtual void Voice()
            {
                Console.WriteLine("Turr Turr");
            }
        }
         //derived bird class
        class Duck : Bird
        {
            public override void Voice()
            {
                Console.WriteLine("Quack Quack");
            }
        }
        /// <summary>
        /// display voice method of base class
        /// </summary>
        /// <returns></returns>
        class Program
        {
            static void Main(string[] args)
            {
                Bird myBird = new Bird();
                Duck myDuck = new Duck();
                myBird.Voice();
                myDuck.Voice();
                Bird mybird1 = new Duck();//DownCasting 
                Duck MyDuck = (Duck)mybird1;//Upcasting
                mybird1.Voice();
                MyDuck.Voice();
                Console.ReadLine();
            }
        }
    }
