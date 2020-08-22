using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_4.add
{
    interface IProductService
    {
        void GetProduct();
        void CreateProduct(AbstractProduct product);
        void UpdateProduct(AbstractProduct product);
        void DeleteProduct(int num);
    }
}
