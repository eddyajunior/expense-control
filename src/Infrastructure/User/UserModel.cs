namespace Infrastructure.User
{
    public record UserModel
    {
        public Guid Id;
        public string Name;
        public bool Active;
        public DateTime CreatedAt;
        public DateTime? UpdatedAt;
    }
}
