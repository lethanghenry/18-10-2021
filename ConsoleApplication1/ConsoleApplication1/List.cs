using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class List
    {
        static List<Product> listProduct = new List<Product>();
        static void AddProduct(Product p)
        {
            listProduct.Add(p);
        }
        static void Display()
        {
            foreach(Product p in listProduct)
            {
                Console.WriteLine(p);
            }
           
        }
        static int find1( string nameProduct)
        {
            Product p = new Product();
            p.name = nameProduct;
            
            return listProduct.IndexOf(p);
        }
        static void findProduct(List<Product> listProduct, string nameProduct)
        {
            Console.WriteLine("nhập name product cần tìm: ");
            nameProduct = Console.ReadLine();
            if (find1(nameProduct) == -1)
                Console.WriteLine("không có name product này");
            else
            {
                Console.WriteLine("Product " + listProduct[find1(nameProduct)]);
            }
        }
    }
}
