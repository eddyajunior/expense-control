using Core.User;
using Core.User.Contracts;

namespace Infrastructure.User
{
    public class UserRepositoryImpl : IUserReporitory
    {
        public Task CreateUser(UserEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserEntity>> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetUserById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUser(Guid id, UserEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
