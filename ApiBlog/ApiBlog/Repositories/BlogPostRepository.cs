using ApiBlog.Data;
using ApiBlog.Interfaces;
using ApiBlog.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiBlog.Repositories
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly AppDbContext _context;
        public BlogPostRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<BlogPost>> GetAll()
        {
            return await _context.BlogPost
                        .Include(p => p.Comments)
                        .ToListAsync();
        }

        public async Task<BlogPost> GetById(int id)
        {
            return await _context.BlogPost
                        .Include(p => p.Comments)
                        .FirstOrDefaultAsync(p => p.Id == id); 
        }

        public async Task<bool> Post(BlogPost post)
        {
            try
            {
                await _context.BlogPost.AddAsync(post);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
