using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Template
{
    internal class WordProcessor : DocumentProcessor
    {
        protected override void Process()
        {
            Console.WriteLine("Process Word File");
        }

        protected override void Read()
        {
            Console.WriteLine("Read Word File");
        }

        protected override void Save()
        {
            Console.WriteLine("Save Word File");
        }
    }
}
