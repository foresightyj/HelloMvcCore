using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMvcCore2.Repositories
{
    public interface IPostRepository
    {
        List<Post> GetPosts();
    }
}
