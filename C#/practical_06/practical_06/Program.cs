using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_06
{
        public delegate void Notify();
        public class ProcessBusinessLogic
        {
            public event Notify ProcessCompleted; // event create
            public void StartProcess()
            {
                Console.WriteLine("Process Started!");
                OnProcessCompleted();
            }
            protected virtual void OnProcessCompleted() //protected virtual method
            {
                //if ProcessCompleted is not null then call delegate
                ProcessCompleted?.Invoke();
            }
        }
    /// <summary>
    /// register event and invoke
    /// </summary>
        class Program
        {
            static void Main(string[] args)
            {
                ProcessBusinessLogic bl = new ProcessBusinessLogic();
                bl.ProcessCompleted += bl_ProcessCompleted; //event register
                bl.StartProcess();//invoke processCompleted
                Console.ReadLine();
            }
            public static void bl_ProcessCompleted()
            {
                Console.WriteLine("Method Invoked");
            }
        
        }
}
