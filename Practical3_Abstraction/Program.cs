using System;

namespace Practical3_Abstraction
{
    class Laptop
    {
        private string brand;
        private string model;
        public string _brand
        {
            set
            {
                 this.brand = value;
            }
            get
            {
                return this.brand;
            }
        }
        public string _model
        {
            set
            {
                this.model=value;
            }
            get
            {
                return this.model;
            }
        }
        public void LaptopDetails()

        {

            Console.WriteLine("Brand: " + this.brand);

            Console.WriteLine("Model: " + this.model);

        }
        private void MotherBoardInfo()

        {

            Console.WriteLine("MotherBoard Information");

        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Laptop l = new Laptop();
            l._brand = "Lenovo";
            l._model = "ThinkPad";
            l.LaptopDetails();  //print brand and model name in output...
          //  l.MotherBoardInfo();  can not access MotherBoardInfo Method because it is private method...
          
        }
    }
}
