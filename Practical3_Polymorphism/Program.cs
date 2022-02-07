using System;

namespace Practical3_Polymorphism
{
    class Bird
    {
        public void Voice()
        {
            Console.WriteLine("Turr Turr");
        }
    }
    class Duck : Bird
    {
        public void Voice()
        {
            Console.WriteLine("Quack Quack");
    }
        }
    class Program
    {
        static void Main(string[] args)
        {
            Bird myBird = new Bird();

            Duck myDuck = new Duck();
            myBird.Voice();  // it will call bird method

            myDuck.Voice(); // it will call duck method
        }
    }
}
