using Clean_arch.Domain.Shared;

namespace Clean_arch.Domain.Users.ValueObjects;

public class PhoneNumber : BaseValueObject
{

    public string Phone { get; private set; }

    public PhoneNumber(string phone)
    {
        if (phone.Length < 11 || phone.Length > 11)
            throw new InvalidDataException();

        Phone = phone;
    }
}