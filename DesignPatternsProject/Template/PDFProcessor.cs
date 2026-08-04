using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Template
{
    internal class PDFProcessor : DocumentProcessor
    {
        protected override void Process()
        {
            Console.WriteLine("Process PDF File");
        }

        protected override void Read()
        {
            Console.WriteLine("Read PDF File");
        }

        protected override void Save()
        {
            Console.WriteLine("Save PDF File");
        }
    }
}
