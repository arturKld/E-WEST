using E_WEST.Models.Academic;

namespace E_WEST.Models.Users
{
    public class Student : User
    {
        public int GroupId { get; set; }

        public Group Group { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
        public ICollection<GradeBook> GradeBooks { get; set; }
    }
}
