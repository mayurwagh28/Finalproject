

// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using spms.Models;

// namespace spms.Controllers;

// public class CourseController : ControllerBase{

//     private SiteDbContext site;

//     CourseController(SiteDbContext site){
//         this.site = site;
//     }
    
//     [HttpPost]
//     public async Task<IActionResult> AddCourse(Course input){
//         var course = site.Courses.Find(input.CourseId);
//         var lastCourse = await site.Courses.OrderByDescending(s => s.CourseId).FirstOrDefaultAsync();
//         Admin admin = new Admin();
//             if(course is null)
//             {
//                 course.CourseId = lastCourse != null ? lastCourse.CourseId + 1 : 5001;
//                 admin.course = new  ;
//                 site.Courses.Add(course);
            
//             site.SaveChanges();
//             return Ok();
//             }
//             else
//             {
//                 return Conflict($"{input.CourseId} already exists.");
//             }       
//     }     
// }