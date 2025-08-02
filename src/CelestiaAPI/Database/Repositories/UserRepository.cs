using CelestiaAPI.Feature.UserFeature;
namespace CelestiaAPI.Database.Repositories;

public class UserRepository : IUserRepository
{

    public Task<long> InsertAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<User>> SelectAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<User?> SelectByIdAsync(long userId)
    {
        throw new NotImplementedException();
    }

    public Task<User?> SelectUserByUserNameAsync(string userName)
    {
        throw new NotImplementedException();
    }

    public Task<User?> SelectUserByUserEmailAsync(string email)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CheckUserExistance(long userId)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task BanUserAsync(long userId)
    {
        throw new NotImplementedException();
    }

    public Task UnbanUserAsync(long userId)
    {
        throw new NotImplementedException();
    }
}