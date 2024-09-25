using System.ComponentModel.DataAnnotations;

namespace UserRegistrationAPI.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    [EmailAddress]
    public string Email { get; set; }
}
