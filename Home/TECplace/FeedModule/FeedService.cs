using System;
using System.Collections.Generic;
using System.Linq;
using PostModule;

namespace FeedModule
{
    public class FeedService
    {
        private List<Post> posts = new List<Post>();

        public List<Post> ObtenerPosts()
        {
            return posts.OrderByDescending(p => p.date).ToList();
        }

        public void AgregarPost(Post post)
        {
            posts.Add(post);
        }
    }
}
