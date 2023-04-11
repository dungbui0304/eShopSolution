using eShopSolution.ViewModels.System.Users;

namespace eShopSolution.Application.System
{
    public interface IUserService
    {
        Task<string> Authenticate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
    }
}
