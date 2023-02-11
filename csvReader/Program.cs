using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            readCSVFile();
            Console.ReadLine();
        }
        static void readCSVFile()
        {
            string[] csvRows = File.ReadAllLines("products.csv"); //questão a ser pensada - dinamicidade (argumento, chamada direta) 

            List<Product> productList = new List<Product>();


            foreach (var line in csvRows)
            {

                string[] lineValues = line.Split(',');

                Product productObj = new Product() { Name = lineValues[0], Price = lineValues[1], Brand = lineValues[2], Weight = lineValues[3] };

                productList.Add(productObj); //if na product
            }
            Console.WriteLine("PRODUCTS");


            productList.ForEach(product => Console.WriteLine($"{product.Name} {product.Price} {product.Brand} {product.Weight}")); //pergunt. brand -, op 1 e 2, dar o print da op escolhioda

        }
    }
}