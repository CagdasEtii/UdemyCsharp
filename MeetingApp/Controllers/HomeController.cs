using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller{
        public IActionResult Index()
        {
            int UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();

            int hour_time = DateTime.Now.Hour;
            
            ViewData["Welcome"] = hour_time >= 7 && hour_time < 12 ? "Günaydın" : 
                hour_time >= 12 && hour_time < 18 ? "İyi günler" : 
                hour_time >= 24 && hour_time < 7 ? "İyi geceler" : "İyi akşamlar" ;

            var meetingInfo = new MeetingInfo(){
                Id = 1,
                Location = "Kurtköy Intertech",
                MeetingDateTime = new DateTime(2024,4,21,8,0,0),
                NumberOfParticipants = UserCount
            };

            return View(meetingInfo);
        }
    }
}