using FaceBookApplication.Domain.Entity.Common;

namespace FaceBookApplication.Domain.Entity
{
    public class User : BaseEntity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime Birth { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Password { get; set; }
        public ICollection<Friend>? Friends { get; set; }
        public ICollection<Post>? Posts { get; set; }

    }
}
