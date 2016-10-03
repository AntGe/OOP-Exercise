using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_album
{
    class AlbumTest
    {
        static void Main(string[] args)
        {
            PhotoAlbum smallAlbum = new PhotoAlbum();
            PhotoAlbum regularAlbum = new PhotoAlbum(24);
            BigPhotoAlbum bigAlbum = new BigPhotoAlbum();
            Console.WriteLine(smallAlbum.NumberOfPages);
            Console.WriteLine(regularAlbum.NumberOfPages);
            Console.WriteLine(bigAlbum.NumberOfPages);
        }
    }
}
