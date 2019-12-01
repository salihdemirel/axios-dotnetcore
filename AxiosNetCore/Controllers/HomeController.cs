using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AxiosNetCore.Models;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace AxiosNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public class MessageBody
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Message { get; set; }
        }

        [HttpGet("AsJson")]
        public JsonResult GetMessages()
        {
            var GetMessage = new MessageBody
            {
                Name = "John",
                Email = "Doe",
                Message = "Lorem Ipsum Dolor Sit amet..."
            };

            return Json(new MessageBody { Name = "John", Email = "Doe" , Message = "Lorem ipsum dolar sit amet" });
        }

    }
}
