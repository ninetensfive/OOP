using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._05___Dependency_Inversion_Principle.Code_Example.Bad_Design
{
    public class ResearchBadDesign
    {
        public ResearchBadDesign(RelashionshipsBadDesign relationships)
        {
            var relations = relationships.Relations;

            foreach (var relation in relations.Where(
                r => r.Item1.Name == "John" && r.Item2 == Relationship.Parent))
            {
                Console.WriteLine($"John has child called {relation.Item3.Name}");
            }
        }
    }
}
