using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            ProxyServer chrome = null;


                  chrome = new ProxyServer();
                  chrome.Search("Proxy Pattern");
                  chrome.Search("Factory Pattern");
                  chrome.Search("Proxy Pattern");
             
        

                



        }
    }
}
