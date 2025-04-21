using E_WEST.Models.Users;

namespace E_WEST.Models.Academic
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LectureHours { get; set; }
        public int PracticeHours { get; set; }
        public int TotalHours => LectureHours + PracticeHours;
        public int GroupId { get; set; }
        public string TeacherId { get; set; }

        public Group Group { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
}
