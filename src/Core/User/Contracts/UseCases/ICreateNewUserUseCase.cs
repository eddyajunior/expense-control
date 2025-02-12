using Core.User.DTOs.Input;
using Core.User.DTOs.Output;

namespace Core.User.Contracts.UseCases
{
    public interface ICreateNewUserUseCase
    {
        Task<CreateNewUserOutput> Execute(CreateNewUserInput input);
    }
}
