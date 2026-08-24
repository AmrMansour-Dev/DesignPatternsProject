using DesignPatternsProject.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Composite
{
    internal class Folder : IFileSystemItem
    {
        private string Name { get; }

        //private List<File> FilesList = new();
        //private List<Folder> FoldersList = new();

        private List<IFileSystemItem> FileSytemItems= new();


        public Folder(string Name)
        {
            this.Name = Name;
        }

        public void Add(IFileSystemItem file)
        {
            FileSytemItems.Add(file);
        }
        //public void Add(Folder folder)
        //{
        //    FoldersList.Add(folder);
        //}

        public int GetSize()
        {
            int TotalSize = 0;

            foreach(var item in FileSytemItems)
            {
                TotalSize += item.GetSize();
            }
            //foreach (var folder in FoldersList)
            //{
            //    TotalSize += folder.GetSize();
            //}

            return TotalSize;
        }
    }
}
