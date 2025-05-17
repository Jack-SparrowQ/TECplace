using System;
using System.Drawing;

namespace PostModule
{
    public class Post
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public Image img { get; set; }
        public string Contenido { get; set; }
        public DateTime date { get; set; }
    }
}
