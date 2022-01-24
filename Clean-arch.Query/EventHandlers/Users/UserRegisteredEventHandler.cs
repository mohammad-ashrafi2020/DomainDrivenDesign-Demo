using Clean_arch.Domain.UserAgg;
using Clean_arch.Domain.UserAgg.Events;
using Clean_arch.Query.Models.Users;
using Clean_arch.Query.Models.Users.Repository;
using MediatR;

namespace Clean_arch.Query.EventHandlers.Users;

internal class UserRegisteredEventHandler : INotificationHandler<UserRegistered>
{
    private readonly IUserReadRepository _readRepository;
    private readonly IUserRepository _writeRepository;

    public UserRegisteredEventHandler(IUserReadRepository readRepository, IUserRepository userRepository)
    {
        _readRepository = readRepository;
        _writeRepository = userRepository;
    }

    public async Task Handle(UserRegistered notification, CancellationToken cancellationToken)
    {
        var user = await _writeRepository.GetbyEmail(notification.Email);
        await _readRepository.Insert(new UserReadModel()
        {
            Email = user.Email,
            CreationDate = user.CreationDate,
            Family = user.Family,
            Id = user.Id,
            Name = user.Name,
            Phone = user.PhoneNumber.Phone
        });
    }
}