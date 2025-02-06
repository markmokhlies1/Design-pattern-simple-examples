using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxcy.Ex
{
    public interface IImage
    {
        void Display();
    }
    // Real Subject
    public class RealImage : IImage
    {
        private readonly string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadImageFromDisk(); // Simulate a costly operation
        }

        private void LoadImageFromDisk()
        {
            Console.WriteLine($"Loading image from disk: {_fileName}");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying image: {_fileName}");
        }
    }

    // Proxy
    public class ProxyImage : IImage
    {
        private readonly string _fileName;
        private RealImage _realImage;

        public ProxyImage(string fileName)
        {
            _fileName = fileName;
        }

        public void Display()
        {
            if (_realImage == null)
            {
                _realImage = new RealImage(_fileName); // Lazy initialization
            }
            _realImage.Display();
        }
    }
}
