using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._05___Dependency_Inversion_Principle.Code_Example.Bad_Design
{
    //low-level
    public class RelashionshipsBadDesign
    {
        private List<(Person, Relationship, Person)> relations = 
            new List<(Person, Relationship, Person)>();

        public List<(Person, Relationship, Person)> Relations => relations;

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Child, parent));
        }
    }
}
