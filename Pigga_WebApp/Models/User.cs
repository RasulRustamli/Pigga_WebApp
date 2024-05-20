using Microsoft.AspNetCore.Identity;

namespace Pigga_WebApp.Models
{
    public class User:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
