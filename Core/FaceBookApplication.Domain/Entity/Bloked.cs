using FaceBookApplication.Domain.Entity.Common;

namespace FaceBookApplication.Domain.Entity
{
    public class Bloked : BaseEntity
    {

        public Like? Like { get; set; }
        public int LikeId { get; set; }

    }
}
