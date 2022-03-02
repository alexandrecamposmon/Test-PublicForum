using System;

namespace PublicForum.ApplicationCore.Models
{
    public class Topic : Entity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string CriationUser { get; set; }
        public DateTime CriationDate { get; set; }
    }
}
