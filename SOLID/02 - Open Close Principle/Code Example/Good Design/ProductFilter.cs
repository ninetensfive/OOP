using SOLID._02___Open_Close_Principle.Code_Example.Good_Design.Interfaces;
using System.Collections.Generic;

namespace SOLID._02___Open_Close_Principle.Code_Example.Good_Design
{
    public class ProductFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var item in items)
            {
                if(spec.IsSatisfied(item))
                {
                    yield return item;
                }
            }
        }
    }
}
