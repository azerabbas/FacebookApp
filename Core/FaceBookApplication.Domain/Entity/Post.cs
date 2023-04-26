using FaceBookApplication.Domain.Entity.Common;

namespace FaceBookApplication.Domain.Entity
{
    public class Post : BaseEntity
    {
        public int FriendId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatDate { get; set; }
        public string? Delete { get; set; }
        public string? Content { get; set; }
        public Friend? Friends { get; set; }
        public User? User { get; set; }
        public ICollection<Comment>? Comments { get; set; }
    }
}
