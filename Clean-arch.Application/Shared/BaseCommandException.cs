namespace Clean_arch.Application.Shared
{
    public class BaseCommandException : Exception
    {
        public BaseCommandException()
        {
        }

        public BaseCommandException(string message) : base(message)
        {
        }
    }

    public class InvalidCommandException : BaseCommandException
    {
        public InvalidCommandException()
        {
        }

        public InvalidCommandException(string message) : base(message)
        {
        }
    }
}