using System;

namespace DebuggingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string userResponse = Console.ReadLine();
            if(Convert.ToBoolean(int.Parse(userResponse)))    //System.FormatException :  Input string was not in a correct format.
            {
                Console.WriteLine("The entered value is a integer");
            }    

        }
    }
}
