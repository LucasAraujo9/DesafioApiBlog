using ApiBlog.DTOs;
using ApiBlog.Interfaces;
using ApiBlog.Models;
using ApiBlog.Repositories;

namespace ApiBlog.Services
{
    public class BlogPostService : IBlogPostService
    {
        private IBlogPostRepository _blogPostRepository;
        public BlogPostService(IBlogPostRepository blogPostRepository)
        {
            _blogPostRepository = blogPostRepository;
        }

        public async Task<List<BlogPost>> GetAll() => await _blogPostRepository.GetAll();
        public async Task<BlogPost> GetById(int id) => await _blogPostRepository.GetById(id);
        public async Task<bool> Post(BlogPost post) => await _blogPostRepository.Post(post);
    }
}
