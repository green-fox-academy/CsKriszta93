using Reddit.Entities;
using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Repositories
{
    public class PostRepository
    {
        PostContext postContext;

        public PostRepository(PostContext postContext)
        {
            this.postContext = postContext;
        }

        public List<Post> GetPosts()
        {
            var posts = (from post in postContext.Posts
                         orderby post.Score descending
                         select post).ToList();
            return posts;
        }

        public void AddPost(string content)
        {
            postContext.Posts.Add(new Post { Content = content });
            postContext.SaveChanges();
        }

        public void VotePositive()
        {

        }
        
        public void VoteNegative()
        {

        }
    }
}
