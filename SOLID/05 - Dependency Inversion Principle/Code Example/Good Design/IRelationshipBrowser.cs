using System.Collections.Generic;

namespace SOLID._05___Dependency_Inversion_Principle.Code_Example.Good_Design
{
    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }
}
