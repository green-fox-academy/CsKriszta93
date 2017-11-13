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

        public Post PostbyId(long id)
        {
            var postById = (from post in postContext.Posts
                            where post.Id == id
                            select post).FirstOrDefault();
            return postById;
        }

        public void VotePositive(string voting, long id)
        {
            if (voting.Equals("plus"))
            {
                PostbyId(id).Score++;
            }
            postContext.Update(PostbyId(id));
            postContext.SaveChanges();
        }
        
        public void VoteNegative(string voting, long id)
        {
            if (voting.Equals("minus"))
            {
                PostbyId(id).Score--;
            }
            postContext.Update(PostbyId(id));
            postContext.SaveChanges();
        }
    }
}
