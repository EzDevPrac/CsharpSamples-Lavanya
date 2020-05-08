using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
   public class RealServer : IChrome 
    {
        private string Filename { get; set; }

        public RealServer(string filename)
        {
            Filename = filename;
            LoadImageFromDisk();
        }
        public void LoadImageFromDisk()
        {
            Console.WriteLine("Loading  : " + Filename);
        }
        public string DisplayResult()
        {
            Console.WriteLine("Displaying  Result From Real Server : " + Filename);
           return "Displaying  Result From Real Server : " + Filename;
        }

    }
}
