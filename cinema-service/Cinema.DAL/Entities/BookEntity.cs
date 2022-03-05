using Cinema.Common.Enums;

namespace Cinema.DAL.Entities
{
    internal class BookEntity : BaseEntity
    {
        public IEnumerable<SessionEntity> Session { get; set; }
        public IEnumerable<UserEntity> User { get; set; }
        public DateTime BookingTime { get; set; }
        public BookingStatus BookingStatus { get; set; }
        public int Place { get; set; }
    }
}
