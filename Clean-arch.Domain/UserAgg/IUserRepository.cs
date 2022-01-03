using Clean_arch.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Domain.UserAgg
{
    public interface IUserRepository
    {
        void Add(User user);
        Task<User> GetById(long id);
        Task SaveChange();
        void Update(User user);

    }
}
