using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        [HttpGet]
        public IActionResult Apply(){
            return View();
        }


        [HttpPost]
        public IActionResult Apply(UserInfo model){
            // Console.WriteLine(Name);
            // Console.WriteLine(Phone);
            // Console.WriteLine(Email);
            // Console.WriteLine(WillAttend);

            if (ModelState.IsValid){
                Repository.AddUser(model);
                ViewBag.UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
                return View("Thanks",model);
            } else {
                return View(model);
            }
        }


        [HttpGet]
        public IActionResult List(){
            return View(Repository.Users);
        }


        // /meeting/detail/3
        [HttpGet]
        public IActionResult Detail(int id){
            return View(Repository.GetById(id));
        }
    }
}