using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_03_1
{
    //class sponsor create
    class Sponsor
    {
        //declaring variable using protected access specifier
        protected string owner = "Rakuteen";
    }
    // child class Team extends parent class sponsor
    class Team : Sponsor
    {
        private string teamname = "Deval";
        /// <summary>
        /// printinfo method prints owner & teamname
        /// </summary>
        /// <returns>string</returns>
        public string printinfo()
        {
            return "owner is " + owner + " team name is " + teamname;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Team t = new Team();//create object of Team class
            Console.WriteLine(t.printinfo());//using reference variable called method 
            Console.ReadLine();//display on console
        }
    }
}