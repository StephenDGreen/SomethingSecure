using System.Security.Claims;

namespace Something.Security
{
    public interface ISomethingUserManager
    {
        ClaimsPrincipal GetUserPrinciple();
    }
}