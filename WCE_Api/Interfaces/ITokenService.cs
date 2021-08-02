using WCE_Api.Entities;

namespace WCE_Api.Interfaces
{
    public interface ITokenService
    {
        string CreateToken (AppUser user);
    }
}