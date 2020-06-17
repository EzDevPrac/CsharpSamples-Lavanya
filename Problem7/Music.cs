using System;
using System.Collections.Generic;
using System.Text;

namespace Problem7
{
   public class Music : Item
    { 
            private string singer;
            private int length;

            public Music()
            {

            }
            public Music(string singer, int length)
            {
                this.singer = singer;
                this.length = length;
            }

            public string Singer
            {
                get { return singer; }
                set { singer = value; }
            }
            public int Lenght
            {
                get { return length; }
                set { length = value; }
            }

            public void Play()
            {
            Console.WriteLine("playing music");
            }
            public void RetrieveInformation()
            {
            Console.WriteLine("Infromation retrived");
            }
        }
}
