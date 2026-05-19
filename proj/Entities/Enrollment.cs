namespace proj.Entities
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public Enrollment()
        {

        }

        public Enrollment(int Id, int studentId, int courseId)
        {
            this.Id = Id;
            this.StudentId = studentId;
            this.CourseId = courseId;
        }
    }
}
