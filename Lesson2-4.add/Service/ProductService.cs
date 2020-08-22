using Lesson2_4.add.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_4.add.Service
{
    class ProductService : IProductService
    {
        AbstractProduct _product;
        public ProductService(AbstractProduct product)
        {
            _product = product;
        }
        public void GetProduct()
        { Console.WriteLine($"Информация по продукту: Имя{_product._name}, Цена {_product._price}, код продукта {_product._productCode}"); }
        public void CreateProduct(AbstractProduct product)
        { Console.WriteLine($"Сохздан продукт {product._name}"); }
        public void UpdateProduct(AbstractProduct product)
        { Console.WriteLine($"Улучшен товар {product._name}"); }
        public void DeleteProduct(int num)
        { Console.WriteLine($"Удален {num} продукт"); }
    }
}
