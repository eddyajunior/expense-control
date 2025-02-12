using Core.User;

namespace Infrastructure.User
{
    public static class UserMapper
    {
        public static UserModel ToModel(this UserEntity entity)
        {
            return new UserModel
            {
                Id = entity.Id,
                Name = entity.Name,
                Active = entity.Active,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt
            };
        }
        public static UserEntity ToEntity(this UserModel model)
        {
            var entity = new UserEntity(model.Name);

            entity.SetId(model.Id);
            entity.SetActive(model.Active);
            entity.SetCreatedAt(model.CreatedAt);
            entity.SetUpdatedAt(model.UpdatedAt);

            return entity;
        }
    }
}
