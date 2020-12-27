using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.ProductName = "abc";
            product.ProductCode = "1234";
            product.ProductPrice = 7.77;

            Console.WriteLine("Product Name: {0} - Code: {1} - Price: {2}", product.ProductName, product.ProductCode, product.ProductPrice);
            Console.Read();
        }
    }

    class Product
    {
        private string productName;
        private string productCode;
        private double productPrice;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public string ProductCode
        {
            get { return productCode; }
            set 
            {
                Random rnd = new Random();
                productCode = value.ToString() + rnd.Next(100, 999).ToString();
            
            }
        }

        public double ProductPrice
        {
            get { return productPrice; }
            set { productPrice = Math.Round(value, 1); }
        }


    }
}
