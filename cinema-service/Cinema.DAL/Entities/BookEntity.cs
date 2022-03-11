using Cinema.Common.Enums;

namespace Cinema.DAL.Entities
{
    public class BookEntity : BaseEntity
    {
        public int Place { get; set; }

        public IEnumerable<SessionEntity> Session { get; set; }

        public IEnumerable<UserEntity> User { get; set; }

        public DateTime BookingTime { get; set; }
        public BookingStatus BookingStatus { get; set; }
    }
}
