using FaceBookApplication.Domain.Entity.Common;

namespace FaceBookApplication.Domain.Entity
{
    public class Like : BaseEntity
    {
        public int CommentId { get; set; }
        public int Likes { get; set; }
        public Comment? Comment { get; set; }
        public ICollection<Bloked>? Blokeds { get; set; }
    }
}
