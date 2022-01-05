using Clean_arch.Domain.Shared;

namespace Clean_arch.Domain.UserAgg.Events
{
    public class UserRegistered : BaseDomainEvent
    {
        public UserRegistered(long userId, string email)
        {
            UserId = userId;
            Email = email;
        }

        public long UserId { get; private set; }
        public string Email { get; private set; }
    }
}
