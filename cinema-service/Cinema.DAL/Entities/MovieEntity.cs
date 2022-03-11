namespace Cinema.DAL.Entities
{
    public class MovieEntity : BaseEntity
    {
        public IEnumerable <SessionEntity> Session { get; set; }

        public AttachmentEntity Attachment { get; set; }
        public Guid AttachmentId { get; set; }
    }
}
