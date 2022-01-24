using Clean_arch.Domain.Shared;
using Clean_arch.Domain.Shared.Exceptions;
using Clean_arch.Domain.UserAgg;
using Clean_arch.Domain.UserAgg.Events;
using Clean_arch.Domain.Users.ValueObjects;

namespace Clean_arch.Domain.Users;

public class User : AggregateRoot
{
    private User()
    {
    }

    public User(string name, string family, PhoneNumber phoneNumber, string email
        , IUserDomainService domainService)
    {
        Guard(email);
        if (domainService.EmailIsExist(email))
            throw new InvalidDomainDataException("ایمیل وارد شده قبلا استفاده شده است");

        Name = name;
        Family = family;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Family { get; private set; }
    public PhoneNumber PhoneNumber { get; private set; }

    public static User Register(string email, string phoneNumber, IUserDomainService domainService)
    {
        var user = new User("", "", new PhoneNumber(phoneNumber), email, domainService);
        user.AddDomainEvent(new UserRegistered(user.Id, email));
        return user;
    }

    private void Guard(string email)
    {
        NullOrEmptyDomainDataException.CheckString(email, nameof(email));
    }
}