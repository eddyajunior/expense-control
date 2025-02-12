namespace Core.User.Contracts
{
    public interface IUserReporitory
    {
        Task<UserEntity> GetUserById(Guid id);        
        Task<IEnumerable<UserEntity>> GetAllUser();
        Task CreateUser(UserEntity entity);
        Task UpdateUser(Guid id, UserEntity entity);
        Task DeleteUser(Guid id);
    }
}
