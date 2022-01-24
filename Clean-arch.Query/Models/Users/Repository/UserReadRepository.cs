using Clean_arch.Query.Shared.Repository;
using MongoDB.Driver;

namespace Clean_arch.Query.Models.Users.Repository;

public class UserReadRepository : BaseReadRepository<UserReadModel>, IUserReadRepository
{
    public UserReadRepository(IMongoClient client) : base(client)
    {
    }

    public async Task<UserReadModel> GetByEmail(string email)
    {
        return await _collection.Find(f => f.Email == email).FirstOrDefaultAsync();
    }
}