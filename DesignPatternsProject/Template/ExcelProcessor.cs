using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Template
{
    internal class ExcelProcessor : DocumentProcessor
    {
        protected override void Process()
        {
            Console.WriteLine("Process Excel File");
        }

        protected override void Read()
        {
            Console.WriteLine("Read Excel File");
        }

        protected override void Save()
        {
            Console.WriteLine("Save Excel File");
        }
    }
}
