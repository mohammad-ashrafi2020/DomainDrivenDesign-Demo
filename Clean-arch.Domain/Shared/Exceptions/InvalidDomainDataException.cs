using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Domain.Shared.Exceptions
{
    public class InvalidDomainDataException : BaseDomainException
    {
        public InvalidDomainDataException()
        {

        }
        public InvalidDomainDataException(string message) : base(message)
        {

        }
    }
}
