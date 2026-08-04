using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Template
{
    internal abstract class DocumentProcessor
    {
        public void ProcessDocument() //Template Method
        {
            Open();
            Read();
            Process();
            Save();
            close();
        }
        public void Open()
        {
            Console.WriteLine("Opening...");
        }

        protected abstract void Read();
        protected abstract void Process();
        protected abstract void Save();
        public void close()
        {
            Console.WriteLine("Closing...");
        }
    }
}
