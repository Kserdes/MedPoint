using Microsoft.AspNetCore.Identity;

namespace MedPoint.Models
{
    public class IdentityAccount : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
