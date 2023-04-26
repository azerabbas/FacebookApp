using FaceBookApplication.Domain.Entity.Common;

namespace FaceBookApplication.Domain.Entity
{
    public class Friend : BaseEntity
    {
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime Birth { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Password { get; set; }
        public User? User { get; set; }
        public ICollection<Post>? Posts { get; set; }
    }
}
