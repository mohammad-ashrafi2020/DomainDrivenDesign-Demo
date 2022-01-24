using Clean_arch.Domain.Users.ValueObjects;
using Clean_arch.Query.Shared;

namespace Clean_arch.Query.Models.Users;

public class UserReadModel : BaseReadModel
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Family { get; set; }
    public string Phone { get; set; }
}