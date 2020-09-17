using System.Collections.Generic;
using System.Security.Claims;

namespace Something.Security
{
    public class SomethingUserManager : ISomethingUserManager
    {
        public ClaimsPrincipal GetUserPrinciple()
        {
            var customClaims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, "Example"),
                new Claim(ClaimTypes.Email, "example@mail.com"),
                new Claim(ClaimTypes.Role, "Admin"),
            };

            var customIdentity = new ClaimsIdentity(customClaims, "Custom Identity");

            var userPrincipal = new ClaimsPrincipal(new[] { customIdentity });
            return userPrincipal;
        }
    }
}
