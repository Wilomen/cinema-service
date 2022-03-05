namespace Cinema.DAL.Entities
{
    internal class UserEntity : BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
