using SocialMediaCore.Core.Entities;
using SocialMediaCore.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaCore.Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        public async Task<IEnumerable<Post>> GetPosts()
        {
            var post = Enumerable.Range(1, 10).Select(x => new Post
            {
                PostID = x,
                UserID = x * 2,
                Description = $"Description {x}",
                Date = DateTime.Now,
                Image = $"rutaImagen",
            });

            await Task.Delay(10);
            return post;
        }
    }
}