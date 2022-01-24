using Clean_arch.Query.Shared.Repository;

namespace Clean_arch.Query.Models.Users.Repository;

public interface IUserReadRepository : IBaseReadRepository<UserReadModel>
{
    Task<UserReadModel> GetByEmail(string email);
}