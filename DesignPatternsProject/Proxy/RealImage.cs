using DesignPatternsProject.Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Proxy
{
    internal class RealImage : Iimage
    {
        private string ImageName;

        public RealImage(string ImageName)
        {
            this.ImageName = ImageName;
            LoadImageFile();
        }

        public void LoadImageFile()
        {
            Console.WriteLine($"Loading {ImageName}, this might take few seconds...");
        }
        public void Display()
        {
            Console.WriteLine($"Displaying {ImageName}...");
        }
    }
}
