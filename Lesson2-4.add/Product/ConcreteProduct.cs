using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_4.add.Product
{
    class ConcreteProduct : AbstractProduct
    {
        public ConcreteProduct(double price, int productCode, string name)
        {
            _price = price;
            _productCode = productCode;
            _name = name;
        }
    }
}
