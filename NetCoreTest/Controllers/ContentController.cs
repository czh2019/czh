using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using NetCoreTest.Models;

namespace NetCoreTest.Controllers
{
    public class ContentController : Controller
    {
        public Content contents;
        public ContentController(IOptions<Content> option)
        {
            contents = option.Value;
        }
        public IActionResult Index()
        {
            return View(new ContentViewModel { Contents = new List<Content> { contents } });
        }
    }
}