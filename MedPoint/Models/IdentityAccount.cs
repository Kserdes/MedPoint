using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace MedPoint.Models
{
    public class IdentityAccount : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
  

    }
}
