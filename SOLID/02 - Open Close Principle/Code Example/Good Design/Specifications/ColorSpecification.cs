using SOLID._02___Open_Close_Principle.Code_Example.Good_Design.Interfaces;

namespace SOLID._02___Open_Close_Principle.Code_Example.Good_Design
{
    public class ColorSpecification : ISpecification<Product>
    {
        private Color color;

        public ColorSpecification(Color color)
        {
            this.color = color;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Color == this.color;
        }
    }
}
