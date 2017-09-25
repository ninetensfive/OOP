namespace SOLID._02___Open_Close_Principle.Code_Example.Good_Design.Interfaces
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}
