using Microsoft.AspNetCore.Mvc;
using proj.Entities;

namespace proj.Controllers
{
    [Route("[controller]")]
    public class EnrollmentController : Controller
    {
        public static List<Enrollment> _enrollments = new List<Enrollment>
        {
            new Enrollment { Id = 1, StudentId = 1, CourseId = 1 },
            new Enrollment { Id = 2, StudentId = 1, CourseId = 2},
            new Enrollment { Id = 3, StudentId = 2, CourseId = 1}
        };

        [HttpGet]
        public IEnumerable<Enrollment> Get()
        {
            return _enrollments;
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var enrollment = _enrollments.FirstOrDefault(e => e.Id == id);
            if (enrollment == null)
                return NotFound();
            return Ok(enrollment);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Enrollment newEnrollment)
        {
            if (newEnrollment == null)
                return BadRequest();
            _enrollments.Add(newEnrollment);
            return Ok(newEnrollment);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Enrollment updatedEnrollment)
        {
            var enrollment = _enrollments.FirstOrDefault(e => e.Id == id);
            if (enrollment == null)
                return NotFound();
            enrollment.StudentId = updatedEnrollment.StudentId;
            enrollment.CourseId = updatedEnrollment.CourseId;
            return Ok(enrollment);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var enrollment = (_enrollments.FirstOrDefault(e => e.Id == id));
            if (enrollment == null)
                return NotFound();
            _enrollments.Remove(enrollment);
            return NoContent();
        }
    }
}
