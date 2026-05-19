namespace proj.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Student()
        {

        }

        public Student(int Id, string name, string phone, string email)
        {
            this.Id = Id;
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
        }
    }
}
