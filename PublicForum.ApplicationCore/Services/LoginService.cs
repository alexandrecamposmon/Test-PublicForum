using PublicForum.ApplicationCore.Interfaces.Repository;
using PublicForum.ApplicationCore.Interfaces.Services;
using PublicForum.ApplicationCore.Models;

namespace PublicForum.ApplicationCore.Services
{
    public class LoginService : Service<Login>, ILoginService
    {
        private readonly ILoginRepository repository;

        public LoginService(ILoginRepository repository) : base(repository)
        {
            this.repository = repository;
        }

    }
}
