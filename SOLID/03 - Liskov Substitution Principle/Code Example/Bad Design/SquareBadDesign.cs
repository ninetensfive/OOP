using SOLID._03___Liskov_Substitution_Principle.Code_Example.BadDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._03___Liskov_Substitution_Principle.Code_Example.BadDesign
{
    public class SquareBadDesign : RectangleBadDesign
    {     
        public new int Width
        {
            set
            {
                base.Width = base.Height = value;
            }
        }

        public new int Height
        {
            set
            {
                base.Height = base.Width = value;
            }
        }
    }
}
