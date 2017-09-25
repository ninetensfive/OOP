using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._05___Dependency_Inversion_Principle.Code_Example.Good_Design
{
    public class Research
    {
        public Research(IRelationshipBrowser browser)
        {
            foreach (var relation in browser.FindAllChildrenOf("John"))
            {
                Console.WriteLine($"John has a child called {relation.Name}");
            }
        }
    }
}
