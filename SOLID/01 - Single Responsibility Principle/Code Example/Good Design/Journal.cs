using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._01___Single_Responsibility_Principle.Code_Example.Good_Design
{
    public class Journal
    {
        private readonly List<string> entries;
        private int count;

        public Journal()
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

        public override string ToString()
        {
            return String.Join(Environment.NewLine, entries);
        }
    }
}
