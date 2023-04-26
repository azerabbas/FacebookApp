using FaceBookApplication.Domain.Entity.Common;

namespace FaceBookApplication.Domain.Entity
{
    public class Comment : BaseEntity
    {
        public int PostId { get; set; }
        public string? Content { get; set; }
        public Post? Post { get; set; }
        public ICollection<Like>? Likes { get; set; }
    }
}
