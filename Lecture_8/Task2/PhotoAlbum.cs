using System;
namespace Lecture_8.Task2
{
    public class PhotoAlbum
    {
        private int numberOfPages;

        public PhotoAlbum(int numberOfPages)
        {
            this.numberOfPages = numberOfPages;
        }

        public PhotoAlbum() : this(16)
        {
        }

        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
    }

}
