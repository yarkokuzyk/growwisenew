using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Growwise.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Growwise1.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationUser _userService;
        private readonly IUpload _uploadService;

        public ProfileController(UserManager<ApplicationUser> userManager,
            IApplicationUser userService,
            IUpload uploadService)
        {
            _userManager = userManager;
            _userService = userService;
            _uploadServce = _uploadService;
        }

        public IActionResult Detail(string id)
        {
            return View();
        }

    }
}