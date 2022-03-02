using PublicForum.ApplicationCore.Interfaces.Repository;
using PublicForum.ApplicationCore.Models;
using PublicForum.Infrastructure.Context;

namespace PublicForum.Infrastructure.Repository
{
    public class TopicRepository : Repository<Topic>, ITopicRepository
    {
        public TopicRepository(ChallengeContext context) : base(context) { }

    }
}
