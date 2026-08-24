using DesignPatternsProject.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Composite
{
    internal class File : IFileSystemItem
    {
        private string Name { get;}
        private int Size { get;}

        public File(string Name, int Size)
        {
            this.Name = Name;
            this.Size = Size;
        }

        public int GetSize()
        {
            return Size;
        }
    }
}
