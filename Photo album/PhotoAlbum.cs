using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_album
{
    class PhotoAlbum
    {
        private int numberOfPages;
        public PhotoAlbum()
        {
            this.NumberOfPages = 16;
        }
        public PhotoAlbum(int NumberOfPages)
        {
            this.NumberOfPages = NumberOfPages;
        }
        public int NumberOfPages { get; set; }
    }
}
