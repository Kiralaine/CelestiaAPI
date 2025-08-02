using CelestiaAPI.Feature.RefreshTokenFeature;
namespace CelestiaAPI.Feature.UserFeature;

public class User
{
    public long UserID { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string Salt { get; set; }
    public UserRole Role { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? DeletedAt { get; set; }
    public bool Banned { get; set; } = false;
    public ICollection<RefreshToken> RefreshTokens { get; set; }
    
}

public enum UserRole
{
    User,
    Admin,
    SuperAdmin,
    Dev,
    Milkyway
}   