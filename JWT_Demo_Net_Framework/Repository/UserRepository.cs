using JWT_Demo_Net_Framework.Entities;
using JWT_Demo_Net_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace JWT_Demo_Net_Framework.Repository
{
    public class UserRepository : GenericRepository<User>
    {
        private List<User> users = new List<User>
        {
            new User{ Id = 1, FirstName = "Hello", LastName = "World1", Username = "Helloworld1", Password = "Test"},
            new User{ Id = 2, FirstName = "Hello", LastName = "World2", Username = "Helloworld2", Password = "Test"},
            new User{ Id = 3, FirstName = "Hello", LastName = "World3", Username = "Helloworld3", Password = "Test"}
        };

        public AuthResponse Authenticate(AuthRequest request)
        {
            var user = users.SingleOrDefault(x => x.Username == request.UserName && x.Password == request.Password);

            if (user == null) return null;

            var token = generateJwtToken(user);

            return new AuthResponse(user, token);
        }

        public IEnumerable<User> SelectAll()
        {
            return users;
        }

        public User SelectById(int id)
        {
            return users.FirstOrDefault(item => item.Id == id);
        }

        public string generateJwtToken(User user)
        {
            //Generate toklen for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();

            //Get Secret value from App set
            var key = Encoding.ASCII.GetBytes(System.Configuration.ConfigurationManager.AppSettings["JWT_SECRET"].ToString());

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}