using ApiBlog.Models;

namespace ApiBlog.Interfaces
{
    public interface IBlogPostRepository
    {
        Task<List<BlogPost>> GetAll();
        Task<BlogPost> GetById(int id);
        Task<bool> Post(BlogPost post);
    }
}
