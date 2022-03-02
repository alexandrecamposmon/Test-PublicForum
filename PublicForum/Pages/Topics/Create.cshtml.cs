using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PublicForum.ApplicationCore.Interfaces.Services;
using PublicForum.ApplicationCore.Models;

namespace PublicForum.Pages.Topics
{
    public class CreateModel : PageModel
    {
        public Topic Topic { get; set; }
        private readonly ITopicService _topicService;
        private string _authMessage = "";
        public CreateModel(ITopicService topicService)
        {
            _topicService = topicService;
        }

        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost(Topic topic)
        {
            // Perform an action only available to authenticated (signed-in) users.

            var userId = HttpContext.User.Identity.Name;
            if (!HttpContext.User.Identity.IsAuthenticated || string.IsNullOrEmpty(userId))
            {
                return RedirectToPage("/Account/Login");
            }
            topic.CriationDate = DateTime.Now;
            topic.CriationUser = userId;
            var add = await _topicService.AddAsync(topic);
            return RedirectToPage("Index", "OnGet");

        }
    }
}
