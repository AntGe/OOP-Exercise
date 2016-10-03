using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_album
{
    class BigPhotoAlbum : PhotoAlbum
    {
        public BigPhotoAlbum() : base()
        {
            this.NumberOfPages = 64;
        }
    }
}
