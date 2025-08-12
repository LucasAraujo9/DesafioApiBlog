using System.Text.Json.Serialization;

namespace ApiBlog.Models
{
    public class Comment
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string? Text { get; set; }

        [JsonIgnore]
        public BlogPost? BlogPost { get; set; }
    }
}
