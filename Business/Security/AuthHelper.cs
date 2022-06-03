using DataAccess.Abstract;
using Entities.Concrete.School;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Business.AuthHelpers
{
    public class AuthHelper
    {
        private IUserDal _userdal;
        private IHttpContextAccessor _httpContextAccessor;

        public AuthHelper(IUserDal userDal, IHttpContextAccessor httpContextAccessor)
        {
            _userdal = userDal;
            _httpContextAccessor = httpContextAccessor;
        }

        public List<Claim> GetUserClaims(User user )
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, user.Email),
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.NameIdentifier,user.FirstName+" "+user.LastName),
            };

            var operationClaims = _userdal.GetOperationClaims(user.Id);

            foreach (var claim in operationClaims)
            {
                claims.Add(new Claim(ClaimTypes.Role, claim.Name));
            }
            return claims;
        }

        public async Task<bool> SecureSignInAsync(string userName,string password )
        {
            var user = _userdal.GetUserByEmailAndPassword(userName, password);
            
            if (user != null)
            {
                var claims = GetUserClaims(user);
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var claimsPrincipal = new ClaimsPrincipal(identity);

                await _httpContextAccessor.HttpContext.SignInAsync(claimsPrincipal);
                return true;
            }

            return false;
        }

        public async Task SecureSignOutAsync()
        {
            await _httpContextAccessor.HttpContext.SignOutAsync();
        }

    }
}
