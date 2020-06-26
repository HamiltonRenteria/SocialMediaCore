using Microsoft.EntityFrameworkCore;
using SocialMediaCore.Core.Entities;
using SocialMediaCore.Core.Interfaces;
using SocialMediaCore.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMediaCore.Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly SocialMediaDBContext _socialMediaDBContext;

        public PostRepository(SocialMediaDBContext socialMediaDBContext)
        {
            _socialMediaDBContext = socialMediaDBContext;
        }

        public async Task<IEnumerable<Post>> GetPosts()
        {
            var posts = await _socialMediaDBContext.Posts.ToListAsync();
            return posts;
        }

        public async Task<Post> GetPost(int PostId)
        {
            var post = await _socialMediaDBContext.Posts.FirstOrDefaultAsync(p => p.PostId == PostId);
            return post;
        }
    }
}