using System;
using System.Collections.Generic;
using System.Text;

namespace RegularExam
{
    public class Perfume
    {
        public Perfume(string brand, double price)
        {
            this.Brand = brand;
            this.Price = price;
        }
        
        private string brand;
        public string Brand
        {
            get { return brand; }
            set { this.brand = value;}
            
        }
        private double price;
        public double Price
        {
            get { return price; }
            set {
                if (value>100)
                {
                    throw  new ArgumentException("Invalid perfume price!");
                }
                else
                {
                    this.price = value; 

                }
                }
        }
        public Perfume AddPerfume(string brand, double price)
        { 
           var perfume = new Perfume(brand, price);
            return perfume;
        }
        public override string ToString()
        {
           return $"Perfume {this.Brand} costs {this.Price:f2}";
        }
    }
}
