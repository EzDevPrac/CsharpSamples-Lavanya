using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
   public class PhotoAlbum
    {
        private int NumberOfpages { get; set; }
         

        public void SetNoOfPages(int n)
        {
            NumberOfpages = n;
        }
        public int GetNumberOfPages()
        {
            return NumberOfpages;
        }
        public PhotoAlbum()
        {
            NumberOfpages = 16;
        }
        public PhotoAlbum(int pages)
        {
            NumberOfpages = pages;
        }
    }
}
