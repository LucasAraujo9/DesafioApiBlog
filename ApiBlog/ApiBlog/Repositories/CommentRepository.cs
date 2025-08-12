using ApiBlog.Data;
using ApiBlog.Interfaces;
using ApiBlog.Models;

namespace ApiBlog.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly AppDbContext _context;
        public CommentRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Post(BlogPost post, Comment comment)
        {
            try
            {
                comment.BlogPost = post;
                _context.Comment.Add(comment);
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
