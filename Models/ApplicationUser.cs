using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace userauth.Models
{
    public class ApplicationUser :IdentityUser
    {
        [StringLength(250)]
        public string FirstName { get; set; }

        [StringLength(250)]
        public string LastName { get; set; }
        public string? Id { get; internal set; }
    }
}
