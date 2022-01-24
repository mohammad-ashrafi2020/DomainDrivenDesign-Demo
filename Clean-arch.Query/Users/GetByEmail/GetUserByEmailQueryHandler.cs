using Clean_arch.Query.Models.Users;
using Clean_arch.Query.Models.Users.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Query.Users.GetByEmail
{
    public class GetUserByEmailQueryHandler : IRequestHandler<GetUserByEmailQuery, UserReadModel>
    {
        private readonly IUserReadRepository _readRepository;

        public GetUserByEmailQueryHandler(IUserReadRepository readRepository)
        {
            _readRepository = readRepository;
        }

        public async Task<UserReadModel> Handle(GetUserByEmailQuery request, CancellationToken cancellationToken)
        {
            return await _readRepository.GetByEmail(request.Email);
        }
    }
}