using SocialMediaCore.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialMediaCore.Core.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetPosts();
    }
}