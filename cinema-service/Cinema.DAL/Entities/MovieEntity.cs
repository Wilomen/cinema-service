namespace Cinema.DAL.Entities
{
    internal class MovieEntity : BaseEntity
    {
        public AttachmentEntity Attachment { get; set; }
        public Guid AttachmentId { get; set; }
        public IEnumerable <SessionEntity> Session { get; set; }
    }
}
