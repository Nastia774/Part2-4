using Lesson2_4.add.Product;
using Lesson2_4.add.Service;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_4.add
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractProduct product2 = new ConcreteProduct(125, 3, "Подушка");

            IProductService productService = new ProductService(product2);
            productService.GetProduct();
            productService.CreateProduct(new ConcreteProduct(54, 4, "Кeфир"));
            productService.UpdateProduct(product2);
            productService.DeleteProduct(3);


            Console.ReadKey();
        }
    }
}
