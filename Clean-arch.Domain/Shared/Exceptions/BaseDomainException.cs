namespace Clean_arch.Domain.Shared.Exceptions
{
    public class BaseDomainException : Exception
    {
        public BaseDomainException()
        {

        }
        public BaseDomainException(string message) : base(message)
        {

        }
    }
}
