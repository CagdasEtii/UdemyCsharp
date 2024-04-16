using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basics.Models
{
    public class CourseRepository
    {
        private static readonly List<Course> _courses = new List<Course>();
        #region Course List
        static CourseRepository(){
            _courses = new List<Course>(){
                new Course(){
                    Id = 1,
                    Title = "ASP.NET Core",
                    Description = "ASP.NET Core anlatıldığı kurs",
                    Image = "asp.jpg",
                    Tags = new string[]{"asp", "net", "csharp", "c#","web geliştirme"},
                    isActive = true,
                    isHome = true
                },
                new Course(){
                    Id = 2,
                    Title = "PHP",
                    Description = "PHP anlatıldığı kurs",
                    Image = "php.jpg",
                    isActive = false,
                    isHome = true
                },
                new Course(){
                    Id = 3,
                    Title = "Django",
                    Description = "Django anlatıldığı kurs",
                    Image = "django.jpg",
                    Tags = new string[]{"django", "python","web geliştirme"},
                    isActive = true,
                    isHome = true
                },
                new Course(){
                    Id = 4,
                    Title = "Javascript",
                    Description = "Javascript anlatıldığı kurs",
                    Image = "js.jpg",
                    isActive = true,
                    isHome = false
                }
            };
        }
        #endregion


        public static List<Course> Courses{
            get{ return _courses; }
        }


        #region Get Course By ID
        public static Course? GetCourseById(int? id){
            return _courses.FirstOrDefault(c => c.Id == id);
        }
        #endregion
    }
}