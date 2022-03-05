namespace Cinema.DAL.Entities
{
    internal class AttachmentEntity : BaseEntity
    {
        public string FormatType { get; set; }
        public byte[] Content { get; set; }
        public IEnumerable<MovieEntity> Movie { get; set; }
    }
}
