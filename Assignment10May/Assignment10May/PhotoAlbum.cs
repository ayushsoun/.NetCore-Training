using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10May
{
    internal class PhotoAlbum
    {
        protected int _numberOfPages;

        public PhotoAlbum() 
        {
            this._numberOfPages = 16;
        }

        public PhotoAlbum(int numberOfPages)
        {
            this._numberOfPages = numberOfPages;
        }

        public int GetNumberOfPages()
        {
            return _numberOfPages;
        }
    }
}
