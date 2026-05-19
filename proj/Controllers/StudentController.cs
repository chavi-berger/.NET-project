using Microsoft.AspNetCore.Mvc;
using proj.Entities;

namespace proj.Controllers
{
    [Route("[controller]")]
    public class StudentController : Controller
    {
        public static List<Student> _students = new List<Student>
        {
           new Student { Id = 1, Name = "יעל כהן", Phone = "050-1234567", Email = "yael@example.com" },
           new Student { Id = 2, Name = "מיכל לוי", Phone = "052-7654321", Email = "michal@example.com" },
           new Student { Id = 3, Name = "שירה לוין", Phone = "054-9876543", Email = "shira@example.com" },
           new Student { Id = 4, Name = "תמר שוורץ", Phone = "053-1112223", Email = "tamar@example.com" },
           new Student { Id = 5, Name = "נועה מילר", Phone = "058-4445556", Email = "noa@example.com" }
        };

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _students;
        }

        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null)
                return NotFound();
            return Ok(student);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Student newStudent)
        {
            if (newStudent == null)
            {
                return BadRequest();
            }
            _students.Add(newStudent);
            return Ok(newStudent);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Student updatedStudent)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null)
                return NotFound();
            student.Name = updatedStudent.Name;
            student.Phone = updatedStudent.Phone;
            student.Email = updatedStudent.Email;

            return Ok(student);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null)
                return NotFound();
            _students.Remove(student);
            return NoContent();
        }
    }
}
