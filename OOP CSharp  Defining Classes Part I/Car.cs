using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CSharp__Defining_Classes_Part_I
{
    public class Car
    {
        private string brand;
        private string model; 
        public Car(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }

        public string Brand
        {
            get {   return this.brand;  }
            set { this.brand = value; }

        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }

        }

        public void CarNoise()
        {
            Console.WriteLine("Bruuuumm!");
        }
        
        
    }
}
