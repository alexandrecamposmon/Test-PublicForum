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
    public class EditModel : PageModel
    {
        public Topic Topic { get; set; }
        private readonly ITopicService _topicService;
        public EditModel(ITopicService topicService)
        {
            _topicService = topicService;
        }
        public void OnGet(int id)
        {
            Topic = _topicService.GetByID(id);
        }
        public async Task<IActionResult> OnPost(Topic topic)
        {
            // Perform an action only available to authenticated (signed-in) users.

            var userId = HttpContext.User.Identity.Name;
            if (!HttpContext.User.Identity.IsAuthenticated || string.IsNullOrEmpty(userId))
            {
                return RedirectToPage("/Account/Login");
            }
            var add = await _topicService.UpdateAsync(topic);
            return RedirectToPage("Index", "OnGet");

        }
    }
}
