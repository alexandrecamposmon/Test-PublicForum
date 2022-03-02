using PublicForum.ApplicationCore.Interfaces.Repository;
using PublicForum.ApplicationCore.Models;
using PublicForum.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicForum.Infrastructure.Repository
{
    public class LoginRepository : Repository<Login>, ILoginRepository
    {
        public LoginRepository(ChallengeContext context) : base(context) { }

    }
}
