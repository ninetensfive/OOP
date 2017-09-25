using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._01___Single_Responsibility_Principle.Code_Example.Bad_Design
{
    public class JournalBadDesign
    {
        private readonly List<string> entries;
        private int count;

        public JournalBadDesign()
        {
            this.entries = new List<string>();
        }

        public int AddEntry(string text)
        {
            entries.Add($"{++this.count}: {text}");
            return this.count; 
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        //Bad Design
        public void Save(string filename)
        {
            File.WriteAllText(filename, this.ToString());
        }

        //Bad Design
        public static JournalBadDesign Load(string filename)
        {
            throw new NotImplementedException();
        }        

        public override string ToString()
        {
            return String.Join(Environment.NewLine, entries);
        }
    }
}
