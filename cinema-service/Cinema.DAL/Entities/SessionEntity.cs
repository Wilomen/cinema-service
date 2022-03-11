namespace Cinema.DAL.Entities
{
    public class SessionEntity : BaseEntity
    {
        public DateTime SessionTime { get; set; }

        public IEnumerable<HallEntity> Hall { get; set; }

        public MovieEntity Movie { get; set; }
        public Guid MovieId { get; set; }
    }
}
