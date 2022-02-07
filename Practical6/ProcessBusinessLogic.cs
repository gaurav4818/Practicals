using System;
using System.Collections.Generic;
using System.Text;

namespace Practical6
{
    public delegate void mydelegate();
    class ProcessBusinessLogic
    {
        
        public event mydelegate ProcessCompleted;
        public void StartProcess()  //this is start process method

        {

            Console.WriteLine("Process Started!");

            OnProcessCompleted(); //calling the method 

        }

        protected virtual void OnProcessCompleted() //protected virtual method

        {
            ProcessCompleted?.Invoke();   //Here Event Invoked then the method that subscribe for event will notified...
                                          // for ex bl_ProcessCompleted() method is subscriber of event so it will called...
        }
    }
}
