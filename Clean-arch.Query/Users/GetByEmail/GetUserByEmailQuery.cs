using Clean_arch.Query.Models.Users;
using MediatR;

namespace Clean_arch.Query.Users.GetByEmail;

public record GetUserByEmailQuery(string Email) : IRequest<UserReadModel>;