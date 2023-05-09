using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Growwise.Data;
using Growwise.Data.Models;
using Growwise1.Models.Forum;
using Microsoft.AspNetCore.Mvc;

namespace Growwise1.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumService;
        public ForumController(IForum forumService)
        {
            _forumService = forumService;
        }
        public IActionResult Index()
        {
            var forums = _forumService.GetAll()
                .Select(forum => new ForumListingModel {
                    Id = forum.Id,
                    Name = forum.Title,
                    Description = forum.Description
            });

            var model = new ForumIndexModel
            {
                ForumList = forums
            };

            return View(model);
        }

        public IActionResult Topic (int id)
        {
            var forum = _forumService.GetById(id);

        }
    }
}