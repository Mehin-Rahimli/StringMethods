using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods2
{
    internal class Product
    {
        public string Id;
        public string BrandName;
        public string Model;
        public decimal Price;
        public decimal Cost;
        public decimal Income;
        public int Count;

        public Product(string brandname, string model, decimal price, decimal cost, int count)
        {
            BrandName = brandname;
            Model = model;
            Price = price;
            Cost = cost;
            Count = count;
            Income = 0;
            Id = GetId(BrandName,Model);
        }
        public string GetId(string brandname, string model)
        {
            string GetBrand = BrandName.Substring(0, 2);
            string GetModel=Model.Substring(0, 2);
            return GetBrand+GetModel;

        }
        public void GetInfo()
        {
            Console.WriteLine($"{ BrandName},{ Model},{Price},{Cost},{Count},{Income},{Id}");
        }

        public void Sale(int number)
        {
            if(number > 0 && number<=Count)
            {
                Count-=number;
                Income+=number*(Price-Cost);
            }
            else
            {
                Console.WriteLine("satilmadi");
            }
        }




    }
}
