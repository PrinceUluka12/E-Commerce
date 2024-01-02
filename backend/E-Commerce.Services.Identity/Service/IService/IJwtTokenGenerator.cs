using E_Commerce.Services.Identity.Model;

namespace E_Commerce.Services.Identity.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles);
    }
}
