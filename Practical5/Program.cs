using System;

namespace Practical5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 10, 30, 20, 50, 40 };
            try
            {
                for (int i = 0; i <=5; i++)
                {

                    Console.WriteLine(arr[i]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);   //print the exception message
            }
            finally
            {
                Console.WriteLine("This is Finally Block...");
            }
        }
    }
}
