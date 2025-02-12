namespace Core.User
{
    public class UserEntity
    {
        public UserEntity(string name)
        {
            Id = new Guid();
            Name = name;
            Active = true;
            CreatedAt = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public bool Active { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }

        public void SetUpdatedAt(DateTime? updatedAt)
        {
            UpdatedAt = updatedAt;
        }

        public void SetCreatedAt(DateTime createdAt)
        {
            CreatedAt = createdAt;
        }

        public void SetActive(bool active)
        {
            Active = active;
        }

        public void SetId(Guid id)
        {
            Id = id;
        }
    }
}
