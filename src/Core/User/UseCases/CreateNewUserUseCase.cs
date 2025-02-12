using Core.User.Contracts;
using Core.User.Contracts.UseCases;
using Core.User.DTOs.Input;
using Core.User.DTOs.Output;

namespace Core.User.UseCases
{
    public class CreateNewUserUseCase : ICreateNewUserUseCase
    {
        private readonly IUserService userService;

        public CreateNewUserUseCase(IUserService userService)
        {
            this.userService = userService;
        }

        public Task<CreateNewUserOutput> Execute(CreateNewUserInput input)
        {
            throw new NotImplementedException();
        }
    }
}
