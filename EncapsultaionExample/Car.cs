using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EncapsultaionExample
{
    public class Car
    {
        private string brand;
        private string model;
        private string color;
        private int numberOfDoor;


        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set {  model = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        } 
        public int NumberOfDoor
        {
            get
            {
                return numberOfDoor;
            }
            set{ 
            if(value!=2 && value != 4)
                {
                    Console.WriteLine("2 veya 4 dışında kapı sayısı girilemez.");
                    numberOfDoor = -1;
                }
            else
                {
                    numberOfDoor = value;
                }
            }
        }
        public void CarInfo()
        {
            Console.WriteLine("Car brand: "+brand+","+"Car model: "+model+","+"Color: "+color+","+"Number of door: "+numberOfDoor);
        }
    }
}
