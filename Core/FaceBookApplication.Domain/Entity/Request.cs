using FaceBookApplication.Domain.Entity.Common;

namespace FaceBookApplication.Domain.Entity
{
    public class Request : BaseEntity
    {
        public int LikeId { get; set; }
        public Like? Like { get; set; }
    }
}
