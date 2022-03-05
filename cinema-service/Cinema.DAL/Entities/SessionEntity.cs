namespace Cinema.DAL.Entities
{
    internal class SessionEntity : BaseEntity
    {
        public IEnumerable<HallEntity> Hall { get; set; }
        public MovieEntity Movie { get; set; }
        public Guid MovieId { get; set; }
        public DateTime SessionTime { get; set; }
    }
}
