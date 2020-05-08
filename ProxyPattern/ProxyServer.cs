using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class ProxyServer 
    {
        private RealServer real = null;
        List<string> search = new List<string>();
        private bool result = false;
        private string Url;

        public void Search(string url)
        {
            Url = url;
            result = SearchUrlInCache(url);
            DisplayResult();

        }
        public bool SearchUrlInCache(string url)
        {
            bool count = false;
            for(int i=0;i<search.Count;i++)
            {
                if(url.Equals(search[i]))
                {
                    count = true;
                }
            }
            return count;
        }
        public void DisplayResult()
        {
            if(result == false)
            {
                real = new RealServer(Url);

                search.Add(Url);
                real.DisplayResult();
            }
            else
            {
                Console.WriteLine("Displaying Result From Cache  : " + Url);

            }
        }

    }
}
