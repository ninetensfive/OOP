using SOLID._02___Open_Close_Principle.Code_Example.Good_Design.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._02___Open_Close_Principle.Code_Example.Good_Design.Specifications
{
    public class AndSpecification<T> : ISpecification<T>
    {
        IEnumerable<ISpecification<T>> specifications;

        public AndSpecification(IEnumerable<ISpecification<T>> specifications)
        {
            this.specifications = specifications;            
        }

        public bool IsSatisfied(T t)
        {
            return !this.specifications.Any(s => !s.IsSatisfied(t));
        }
    }
}
