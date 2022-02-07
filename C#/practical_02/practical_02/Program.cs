using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_02
{
    class Customer_Account
    {
        //create 3 variable
        public string bank_name;
        private long customer_accountNo;
        private string customer_name;
        //create parameterized constructor 
        public Customer_Account(long customer_accountNo, string customer_name)
        {
            this.customer_accountNo = customer_accountNo;
            this.customer_name = customer_name;
        }
        /// <summary>
        /// printinfo method prints bank name ,customer accountNo and customer name
        /// </summary>
        /// <returns></returns>
        public string printinfo()
        {
                return bank_name + " " +customer_accountNo + " " + customer_name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer_Account c1 = new Customer_Account(101, "Deval");//create object of class Customer_Account & Pass parameters
            c1.bank_name = "BOB";//initialize bank_name
            Console.WriteLine(c1.printinfo());//using refernce variable call printinfo method
            Console.ReadLine();//display on console
        }
    }
}
