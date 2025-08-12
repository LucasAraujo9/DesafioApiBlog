using ApiBlog.Models;

namespace ApiBlog.Interfaces
{
    public interface ICommentService
    {
        Task<bool> Post(int id, Comment comment);
    }
}
