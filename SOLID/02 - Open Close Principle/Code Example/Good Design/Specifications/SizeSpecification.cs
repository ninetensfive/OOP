using SOLID._02___Open_Close_Principle.Code_Example.Good_Design.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._02___Open_Close_Principle.Code_Example.Good_Design
{
    public class SizeSpecification : ISpecification<Product>
    {
        private Size size;

        public SizeSpecification(Size size)
        {
            this.size = size;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Size == this.size;
        }
    }
}
