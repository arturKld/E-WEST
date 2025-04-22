using E_WEST.Models.Users;

namespace E_WEST.Models.Academic
{
    public class Lesson
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Topic { get; set; }
        public int SubjectId { get; set; }
        public string StudentId { get; set; }
        public int? GradeValue { get; set; } // 2-5
        public bool IsPresent { get; set; }
        public string Comment { get; set; }

        public Subject Subject { get; set; }
        public Student Student { get; set; }
    }
}
