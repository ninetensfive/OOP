using System;

namespace SOLID._04___Interface_Segregation_Principle.Code_Example.Bad_Design
{
    public class OldFashionedPrinter : IMachine
    {
        //This Printer cannot Fax
        public void Fax(Document document)
        {
            throw new NotImplementedException();
        }

        public void Print(Document document)
        {
            throw new NotImplementedException();
        }

        //This Printer cannot Scan
        public void Scan(Document document)
        {
            throw new NotImplementedException();
        }
    }
}
