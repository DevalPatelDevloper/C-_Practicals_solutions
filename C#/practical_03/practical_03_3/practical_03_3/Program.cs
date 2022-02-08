using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_03_3
{
    class Laptop
    {
        private string brand { get; set; }
        private string model { get; set; }
        public Laptop(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }
        public void LaptopDetails()
        {
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Model: " + model);
        }

        private void MotherBoardInfo()
        {
            Console.WriteLine("MotherBoard Information");
        }
    }
        /// <summary>
        /// private method is not access in another class
        /// </summary>
        /// <returns></returns>
    class Program
    {
        static void Main(string[] args)
        {
            Laptop l = new Laptop("Acer", "i3");
            l.LaptopDetails();
           // l.MotherBoardInfo();//if called then error
            Console.ReadLine();
        }
    }
}
