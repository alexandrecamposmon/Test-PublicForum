using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PublicForum.ApplicationCore.Interfaces.Services;
using PublicForum.ApplicationCore.Models;

namespace PublicForum.Pages.Topics
{
    public class IndexModel : PageModel
    {
        private readonly ITopicService _topicService;
        public IEnumerable<Topic> Topics { get; set; }
        public IndexModel(ITopicService topicService)
        {
            _topicService = topicService;
        }
        public void OnGet()
        {
            Response.Cookies.Append("MyCookie", "testeNome1");
            Topics = _topicService.FindAll(0, 100).ToList().OrderByDescending(x => x.CriationDate);
        }
    }
}
