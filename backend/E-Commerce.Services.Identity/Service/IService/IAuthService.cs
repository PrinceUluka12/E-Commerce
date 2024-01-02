using E_Commerce.Services.Identity.Models.Dto;

namespace Mango.Services.Identity.Service.IService
{
    public interface IAuthService
    {
        Task<string> Register(RegistrationRequestDTO registrationRequestDTO);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);

        Task<bool> AssignRole(string email, string roleName);
    }
}
