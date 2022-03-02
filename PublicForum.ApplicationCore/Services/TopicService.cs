using PublicForum.ApplicationCore.Interfaces.Repository;
using PublicForum.ApplicationCore.Interfaces.Services;
using PublicForum.ApplicationCore.Models;

namespace PublicForum.ApplicationCore.Services
{
    public class TopicService : Service<Topic>, ITopicService
    {
        private readonly ITopicRepository repository;

        public TopicService(ITopicRepository repository) : base(repository)
        {
            this.repository = repository;
        }

    }
}
