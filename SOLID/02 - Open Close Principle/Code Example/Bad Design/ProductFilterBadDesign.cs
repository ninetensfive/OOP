using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._02___Open_Close_Principle.Code_Example.Bad_Design
{
    public class ProductFilterBadDesign
    {
        public IEnumerable<Product> FilterBySize(
            IEnumerable<Product> products, Size size)
        {
            foreach (var product in products)
            {
                if (product.Size == size)
                {
                    yield return product;
                }
            }
        }

        public IEnumerable<Product> FilterByColor(
           IEnumerable<Product> products, Color color)
        {
            foreach (var product in products)
            {
                if (product.Color == color)
                {
                    yield return product;
                }
            }
        }
    }
}
