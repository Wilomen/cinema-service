namespace Cinema.DAL.Entities
{
    public class HallEntity : BaseEntity
    {
        public int PlaceQuantity { get; set; }

        public IEnumerable<CinemaEntity> Cinema { get; set; }
    }
}
