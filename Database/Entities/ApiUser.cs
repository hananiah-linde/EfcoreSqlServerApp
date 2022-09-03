using Microsoft.AspNetCore.Identity;

namespace Database.Entities;
public class ApiUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}