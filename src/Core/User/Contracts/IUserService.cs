namespace Core.User.Contracts
{
    public interface IUserService
    {
        Task<UserEntity> GetById(int id);
        Task<IEnumerable<UserEntity>> GetAll();
        Task Create(UserEntity entity);
        Task Update(int id, UserEntity entity);
        Task Delete(int id);

    }
}
