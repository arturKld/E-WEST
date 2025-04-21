using E_WEST.Models.Academic;

namespace E_WEST.Models.Users
{
    public class Teacher : User
    {
        public ICollection<Subject> Subjects { get; set; }
        public ICollection<TeacherDepartment> Departments { get; set; }
        public ICollection<GradeBook> GradeBooks { get; set; }
    }
}
