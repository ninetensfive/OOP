using System.Collections.Generic;

namespace SOLID._02___Open_Close_Principle.Code_Example.Good_Design.Interfaces
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}
