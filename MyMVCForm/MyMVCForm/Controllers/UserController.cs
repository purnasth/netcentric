using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using MVCExample.Models;

namespace MVCExample.Controllers
{
    public class UserController : Controller
    {
        // Action to display the form
        public ActionResult Create(string username = "", string email = "")
        {
            var model = new UserModel
            {
                Username = username,
                Email = email
            };

            return View(model);
        }

        // Action to handle form submission
        [HttpPost]
        public ActionResult Create(UserModel user)
        {
            if (ModelState.IsValid)
            {
                TempData["Message"] = "User data submitted successfully!";
                return RedirectToAction("Create");
            }

            return View(user);
        }
    }
}
