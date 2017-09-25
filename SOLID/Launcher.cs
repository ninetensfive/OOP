using SOLID._01___Single_Responsibility_Principle.Code_Example.Bad_Design;
using SOLID._01___Single_Responsibility_Principle.Code_Example.Good_Design;
using SOLID._02___Open_Close_Principle.Code_Example;
using SOLID._02___Open_Close_Principle.Code_Example.Bad_Design;
using SOLID._02___Open_Close_Principle.Code_Example.Good_Design;
using SOLID._02___Open_Close_Principle.Code_Example.Good_Design.Interfaces;
using SOLID._02___Open_Close_Principle.Code_Example.Good_Design.Specifications;
using SOLID._03___Liskov_Substitution_Principle.Code_Example;
using SOLID._03___Liskov_Substitution_Principle.Code_Example.BadDesign;
using SOLID._03___Liskov_Substitution_Principle.Code_Example.Good_Design;
using SOLID._05___Dependency_Inversion_Principle.Code_Example;
using SOLID._05___Dependency_Inversion_Principle.Code_Example.Bad_Design;
using SOLID._05___Dependency_Inversion_Principle.Code_Example.Good_Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            //01 - Single Responsibility
            SRBadDesign();

            //02 - Open Close Principle            
            var products = GetProducts();
            OCPBadDesign(products);
            OCP(products);

            //03 - Liskov Substitution Principle            
            LSPBadDesign();
            LSP();

            //05 - Dependency Inversion Principle
            DIPBadDesign();
            DIP();
        }

        private static void DIP()
        {
            var parent = new Person { Name = "John" };
            var child1 = new Person { Name = "Chris" };
            var child2 = new Person { Name = "Mary" };

            var relationships = new Relationships();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);

            new Research(relationships);
        }

        private static void DIPBadDesign()
        {
            var parent = new Person { Name = "John" };
            var child1 = new Person { Name = "Chris" };
            var child2 = new Person { Name = "Mary" };

            var relationships = new RelashionshipsBadDesign();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);

            new ResearchBadDesign(relationships);
        }

        private static void LSP()
        {
            Rectangle rc = new Rectangle(2, 3);
            Console.WriteLine($"{rc} has area {rc.Area()}");


            Rectangle sq = new Square();
            sq.Width = 4;
            Console.WriteLine(sq);
        }

        private static void LSPBadDesign()
        {
            RectangleBadDesign rc = new RectangleBadDesign(2, 3);
            Console.WriteLine($"{rc} has area {rc.Area()}");


            RectangleBadDesign sq = new SquareBadDesign();
            sq.Width = 4;
            Console.WriteLine(sq);
        }

        private static void SR()
        {
            var journal = new Journal();
            journal.AddEntry("SR This is a test day");
            journal.AddEntry("SR");

            //separate concern
            //var p = new Persistence();
            //p.SaveToFile(journal, @"c:\temp\journal.txt", true);

            Console.WriteLine(journal);
        }

        private static void SRBadDesign()
        {
            var journal = new JournalBadDesign();
            journal.AddEntry("SR Bad Design This is a test day");
            journal.AddEntry("SR So Bad Design");
            Console.WriteLine(journal);
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product>();

            products.Add(new Product("Apple", Color.Green, Size.Small));
            products.Add(new Product("Tree", Color.Green, Size.Large));
            products.Add(new Product("House", Color.Blue, Size.Large));

            return products;
        }

        private static void OCPBadDesign(List<Product> products)
        {
            var productFilter = new ProductFilterBadDesign();
            Console.WriteLine("Green Products (bad design):");

            foreach (var product in productFilter.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($"{product.Name} is green");
            }
        }

        private static void OCP(List<Product> products)
        {
            Console.WriteLine("Green Products (good design):");

            ISpecification<Product> specification = new ColorSpecification(Color.Green);
            var productFilter = new ProductFilter();

            foreach (var product in productFilter.Filter(products, specification))
            {
                Console.WriteLine($"{product.Name} is green");
            }

            var specifications = new List<ISpecification<Product>>()
            {
               new ColorSpecification(Color.Blue),
               new SizeSpecification(Size.Large)
            };
            ISpecification<Product> andSpecifications = new AndSpecification<Product>(specifications);

            foreach (var product in productFilter.Filter(products, andSpecifications))
            {
                Console.WriteLine($"{product.Name} is blue and large");
            }
        }
    }
}
