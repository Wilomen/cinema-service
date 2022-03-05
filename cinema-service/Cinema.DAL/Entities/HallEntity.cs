namespace Cinema.DAL.Entities
{
    internal class HallEntity : BaseEntity
    {
        public IEnumerable<CinemaEntity> Cinema { get; set; }
        public int PlaceQuantity { get; set; }
    }
}
