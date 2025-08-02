using CelestiaAPI.Feature.UserFeature;
namespace CelestiaAPI.Database.Repositories;

public interface IUserRepository
{
        Task<long> InsertAsync(User user);
        Task<ICollection<User>> SelectAllAsync();

        Task<User?> SelectByIdAsync(long userId);
        Task<User?> SelectUserByUserNameAsync(string userName);
        Task<User?> SelectUserByUserEmailAsync(string email);
        Task<bool> CheckUserExistance(long userId);
        Task DeleteAsync(User user);
        Task UpdateAsync(User user);
        Task BanUserAsync(long userId);
        Task UnbanUserAsync(long userId);
}