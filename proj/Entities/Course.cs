namespace proj.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Course()
        {

        }
        public Course(int Id, string name, string description)
        {
            this.Id = Id;
            this.Name = name;
            this.Description = description;
        }
    }
}
