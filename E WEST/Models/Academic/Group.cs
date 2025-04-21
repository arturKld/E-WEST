using E_WEST.Models.Users;

namespace E_WEST.Models.Academic
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } // "ИТ-21"
        public int Course { get; set; } // 1-4
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Subject> Subjects { get; set; }
    }
}
