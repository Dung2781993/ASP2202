using JWT_Demo_Net_Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JWT_Demo_Net_Framework.Models
{
    public class AuthResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Token { get; set; }

        public AuthResponse(User user, string token)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Token = token;
        }
    }
}