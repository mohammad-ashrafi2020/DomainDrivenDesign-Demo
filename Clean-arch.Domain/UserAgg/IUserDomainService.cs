using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Domain.UserAgg
{
    public interface IUserDomainService
    {
        public bool EmailIsExist(string email);
    }
}