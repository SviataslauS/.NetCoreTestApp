using AspNetCoreTestApp.Common;
using AspNetCoreTestApp.Database;
using AspNetCoreTestApp.Database.Models;
using AspNetCoreTestApp.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using AspNetCoreTestApp.DAL.Models.EntityExtentions;

namespace AspNetCoreTestApp.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthenticationService(DatabaseContext context, AppSettings settings)
        {
            Context = context;
            AppSettings = settings;
        }

        private DatabaseContext Context { get; set; }
        private AppSettings AppSettings { get; set; }

        public AuthUser AuthenticateByCredentials(string userName, string password)
        {
            var user = VerifyUserCredentials(userName, password);
            if(user == null)
            {
                return null;
            }

            var key = Encoding.ASCII.GetBytes(AppSettings.JwtVerifySecret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return new AuthUser { UserId = user.UserId, TokenString = tokenString, IsAdmin = user.Role.IsAdmin()};
        }

        private User VerifyUserCredentials(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                return null;

            var user = Context.Users.SingleOrDefault(x => x.Name == userName);

            if (user == null)
                return null;

            if (!VerifyPasswordHash(password, user))
                return null;

            return user;
        }

        private static bool VerifyPasswordHash(string password, User user)
        {
          // password+salt hash validation

            return true;
        }
    }
}