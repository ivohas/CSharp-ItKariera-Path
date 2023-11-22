using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegularExam
{
    public class Perfumery
    {
        private string name;
        private List<Perfume> perfumes;

        public Perfumery(string name)
        {
            this.Name = name;
            perfumes = new List<Perfume>();

        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 6)
                {
                    throw new ArgumentException("Invalid perfumery name!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public Perfumery CreatePerfumery(string name)
        {
            var perfumery = new Perfumery(name);
            return perfumery;
        }

        public void AddPerfume(Perfume perfume)
        {

            this.perfumes.Add(perfume);
        }

        public bool SellPerfume(Perfume perfume)
        {
           
            if (this.perfumes.FirstOrDefault(p => p.Price == perfume.Price && p.Brand == perfume.Brand) == null)
                {
                    return false;
                }
                this.perfumes.Remove(this.perfumes.FirstOrDefault(p => p.Price == perfume.Price && p.Brand == perfume.Brand));
                return true;
            


        }

        public double CalculateTotalPrice()
        {
            double sum = 0;
            foreach (var item in perfumes)
            {
                sum += item.Price;
            }
            return sum;
        }

        public Perfume GetPerfumeWithHighestPrice()
        {
            Perfume perfume = null;
            double price = double.MinValue;
            foreach (var item in perfumes)
            {
                if (price < item.Price)
                {
                    price = item.Price;
                    perfume = item;
                }
            }
            return perfume;
        }

        public Perfume GetPerfumeWithLowestPrice()
        {
            Perfume perfume = null;
            double price = double.MaxValue;
            foreach (var item in perfumes)
            {
                if (price > item.Price)
                {
                    price = item.Price;
                    perfume = item;
                }
            }
            return perfume;
        }

        public void RenamePerfumery(string newName)
        {
            this.Name = newName;
        }

        public void SellAllPerfumes()
        {
            perfumes.Clear();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Perfumery {this.Name} has {this.perfumes.Count} perfume/s:");

            foreach (Perfume p in this.perfumes)
                sb.AppendLine($"Perfume {p.Brand} costs {p.Price:f2}");

            return this.perfumes.Count > 0 ? sb.ToString() : $"Perfumery {this.Name} has no available perfumes.";
        }
    }
}
