using System;

namespace Problem2
{
    class AlbumTest
    {
        static void Main(string[] args)
        {
            PhotoAlbum album = new PhotoAlbum();
            Console.WriteLine(album.GetNumberOfPages()+" Pages Album is Created");
            album = new PhotoAlbum(24);
            Console.WriteLine(album.GetNumberOfPages()+" Pages Album is  Created");
            BigPhotoAlbum big = new BigPhotoAlbum();
            Console.WriteLine(big.GetNumberOfPages() + " Pages Album is Created");

        }
    }
}
