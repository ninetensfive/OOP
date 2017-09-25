using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._04___Interface_Segregation_Principle.Code_Example.Good_Design
{
    public class Photocopier : IPrinter, IScanner
    {
        public void Print(Document document)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document document)
        {
            throw new NotImplementedException();
        }
    }
}
