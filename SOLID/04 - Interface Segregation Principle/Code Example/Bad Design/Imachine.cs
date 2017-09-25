namespace SOLID._04___Interface_Segregation_Principle.Code_Example.Bad_Design
{
    public interface IMachine
    {
        void Print(Document document);
        void Scan(Document document);
        void Fax(Document document);
    }
}
