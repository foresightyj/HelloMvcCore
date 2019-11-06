using HelloMvcCore2.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMvcCore2.ViewComponents
{
    public class PostsViewComponent : ViewComponent
    {
        private readonly IPostRepository _repo;
        public PostsViewComponent(IPostRepository repo)
        {
            _repo = repo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            await Task.Delay(100);
            var posts = _repo.GetPosts();
            return View("Posts", posts);
        }
    }
}
