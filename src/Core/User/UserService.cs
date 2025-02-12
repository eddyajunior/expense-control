using Core.User.Contracts;

namespace Core.User
{
    public class UserService : IUserService
    {
        private readonly IUserReporitory userReporitory;

        public UserService(IUserReporitory userReporitory)
        {
            this.userReporitory = userReporitory;
        }

        public Task Create(UserEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, UserEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
