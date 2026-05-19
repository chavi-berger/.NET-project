using Microsoft.AspNetCore.Mvc;
using proj.Entities;

namespace proj.Controllers
{

    [Route("[controller]")]
    public class CourseController : Controller
    {
        public static List<Course> _courses = new List<Course>
{
   new Course { Id = 1, Name = "מבוא למדעי המחשב", Description = "יסודות התכנות וחשיבה אלגוריתמית" },
new Course { Id = 2, Name = "מבני נתונים", Description = "ניהול ויעילות זיכרון באמצעות עצים, רשימות ומחסניות" },
new Course { Id = 3, Name = "פיתוח אפליקציות אינטרנט", Description = "בניית שרתים ו-API מתקדמים בטכנולוגיות מודרניות" },
new Course { Id = 4, Name = "בסיסי נתונים ו-SQL", Description = "תכנון ארכיטקטורת נתונים, שאילתות מורכבות ואופטימיזציה" },
new Course { Id = 5, Name = "הנדסת תוכנה וארכיטקטורה", Description = "עקרונות תכנון נכון, תבניות עיצוב (Design Patterns) ומבנה פרויקט" }
};

        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return _courses;
        }

        [HttpGet("{id}")]
        public ActionResult<Course> Get(int id)
        {
            var course = _courses.FirstOrDefault(s => s.Id == id);
            if (course == null)
                return NotFound();
            return Ok(course);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Course newCourse)
        {
            if (newCourse == null)
            {
                return BadRequest();
            }
            _courses.Add(newCourse);
            return Ok(newCourse);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Course updatedCourse)
        {
            var course = _courses.FirstOrDefault(s => s.Id == id);
            if (course == null)
                return NotFound();
            course.Name = updatedCourse.Name;
            course.Description = updatedCourse.Description;
            return Ok(course);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var course = _courses.FirstOrDefault(s => s.Id == id);
            if (course == null)
                return NotFound();
            _courses.Remove(course);
            return NoContent();
        }
    }
}
