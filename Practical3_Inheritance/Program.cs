using System;

namespace Practical3_Inheritance
{
    class Sponsor
    {
        protected string owner= "Rakuteen";


    }
    class Team : Sponsor
    {
        private string teamName;
        public string printInfo()
        {
            string result = owner + " Sponsor";
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Team t = new Team();
            string ans = t.printInfo();
            Console.WriteLine($"Concatenate String : {ans}");
        }
    }
}
