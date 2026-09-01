using DesignPatternsProject.Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Proxy
{
    internal class ProxyImage : Iimage
    {
        private string ImageName;
        private RealImage? realImage;

        public ProxyImage(string ImageName)
        {
            this.ImageName = ImageName;
        }
        public void Display()
        {
            if(realImage == null)
            {
                realImage = new RealImage(ImageName);
            }

            realImage.Display();
        }
    }
}
