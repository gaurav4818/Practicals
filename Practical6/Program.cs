using System;

namespace Practical6
{
    class Program
    {
        public static void bl_ProcessCompleted()  //this method subscribe for event
        {
            Console.WriteLine("Method Invoked");
        }
        static void Main(string[] args)
        {
            ProcessBusinessLogic obj = new ProcessBusinessLogic();  //create object of ProcessBusinessLogic Class
            obj.ProcessCompleted += Program.bl_ProcessCompleted;  //register the method in event
            obj.StartProcess(); //call method for event raise
        }
    }
}
