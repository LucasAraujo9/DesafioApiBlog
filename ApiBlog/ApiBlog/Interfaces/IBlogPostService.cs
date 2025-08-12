using ApiBlog.DTOs;
using ApiBlog.Models;
using ApiBlog.Repositories;

namespace ApiBlog.Interfaces
{
    public interface IBlogPostService
    {
        Task<List<BlogPost>> GetAll();
        Task<BlogPost> GetById(int id);
        Task<bool> Post(BlogPost post);
    }
}
