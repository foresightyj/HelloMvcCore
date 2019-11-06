using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMvcCore2.Repositories
{
    public class PostRepository : IPostRepository
    {
        public List<Post> GetPosts()
        {
            return new List<Post> { new Post { Id = 2, Title = "Hello MVC Core" } };
        }
    }
}
