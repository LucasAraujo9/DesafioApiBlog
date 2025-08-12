using System.Xml.Linq;

namespace ApiBlog.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
