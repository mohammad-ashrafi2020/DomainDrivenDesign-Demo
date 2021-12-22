using Clean_arch.Domain.Shared;

namespace Clean_arch.Domain.Users.ValueObjects;

public class PhoneBook : BaseValueObject
{
    public PhoneNumber TelePhone { get; }
    public PhoneNumber Fax { get; }

    public PhoneBook(PhoneNumber telePhone, PhoneNumber fax)
    {
        TelePhone = telePhone;
        Fax = fax;
    }
}