using E_WEST.Models.Academic;

namespace E_WEST.Models.Users
{
    public class TeacherDepartment
    {
        public string TeacherId { get; set; }
        public int DepartmentId { get; set; }

        public Teacher Teacher { get; set; }
        public Department Department { get; set; }
    }
}
