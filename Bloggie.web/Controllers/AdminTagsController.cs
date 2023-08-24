﻿using Bloggie.web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bloggie.web.Controllers
{
    public class AdminTagsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest)
        {      
            var name = addTagRequest.Name;
            var displayName = addTagRequest.DisplayName;
            return View("Add");
        }
    }
}
