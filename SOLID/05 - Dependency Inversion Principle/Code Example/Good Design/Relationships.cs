using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._05___Dependency_Inversion_Principle.Code_Example.Good_Design
{
    public class Relationships : IRelationshipBrowser
    {
        private List<(Person, Relationship, Person)> relations =
           new List<(Person, Relationship, Person)>();

        public List<(Person, Relationship, Person)> Relations => relations;

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            foreach (var relation in relations.Where(
                r => r.Item1.Name == name && r.Item2 == Relationship.Parent))
            {
               yield return relation.Item3;
            }
        }
    }
}
