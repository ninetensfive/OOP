using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._03___Liskov_Substitution_Principle.Code_Example.Good_Design
{
    public class Rectangle
    {
        public Rectangle()
        {
        }

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int Area()
        {
            return this.Width * this.Height;
        }

        public override string ToString()
        {
            return $"{nameof(this.Width)}: {this.Width}, {nameof(this.Height)}: {this.Height}";
        }
    }
}
