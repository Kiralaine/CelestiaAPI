using CelestiaAPI.Feature.UserFeature;
using Microsoft.EntityFrameworkCore;
namespace CelestiaAPI.Database.Repositories;

public class UserRepository : IUserRepository
{
    private readonly MainContext Maincontext;
    public UserRepository(MainContext context)
    {
        Maincontext = context;
    }
    public async  Task<long> InsertAsync(User user)
    {
        await Maincontext.Users.AddAsync(user);
        await Maincontext.SaveChangesAsync();
        return user.UserID;
    }

    public async  Task<ICollection<User>> SelectAllAsync()
    {
        var users = await Maincontext.Users.ToListAsync();
        return users;
    }

    public  async Task<User?> SelectByIdAsync(long userId)
    {
        var user = await Maincontext.Users.FirstOrDefaultAsync(u => u.UserId == userId);



        return user;
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