using ApiBlog.Models;

namespace ApiBlog.Interfaces
{
    public interface ICommentRepository
    {
        Task<bool> Post(BlogPost post, Comment comment);
    }
}
