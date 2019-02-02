using AspNetCoreTestApp.Database.Models;
using AspNetCoreTestApp.Models;

namespace AspNetCoreTestApp.Services
{
    public interface IAuthenticationService
    {
        AuthUser AuthenticateByCredentials(string login, string password);
    }

}
