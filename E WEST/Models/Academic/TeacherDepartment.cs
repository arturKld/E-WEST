using E_WEST.Models.Users;

namespace E_WEST.Models.Academic
{
    public class TeacherDepartment
    {
        public string TeacherId { get; set; }
        public int DepartmentId { get; set; }

        public Teacher Teacher { get; set; }
        public Department Department { get; set; }
    }
}
