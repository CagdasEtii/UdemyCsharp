using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Basics.Models;

namespace Basics.Controllers;


// course
public class CourseController : Controller{
    public IActionResult Detail(int? id){
        if(id == null){
            // return Redirect("/course/list/");
            return RedirectToAction("List","Course");
        }
        var course = CourseRepository.GetCourseById(id);
        return View("CourseDetail",course);
    }

    public IActionResult List(){
        return View("CourseList",CourseRepository.Courses);
    }
}