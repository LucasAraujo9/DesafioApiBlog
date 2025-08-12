using ApiBlog.Interfaces;
using ApiBlog.Models;
using ApiBlog.Repositories;

namespace ApiBlog.Services
{
    public class CommentService : ICommentService
    {
        private ICommentRepository _commentRepository;
        private IBlogPostRepository _blogPostRepository;
        public CommentService(ICommentRepository commentRepository, IBlogPostRepository blogPostRepository)
        {
            _commentRepository = commentRepository;
            _blogPostRepository = blogPostRepository;
        }

        public async Task<bool> Post(int id, Comment comment)
        {
            var post = await _blogPostRepository.GetById(id);

            if (post is null)
                return false;

            return await _commentRepository.Post(post, comment);
        }
    }
}
