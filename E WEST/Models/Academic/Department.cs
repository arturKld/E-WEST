using System.Text.RegularExpressions;

namespace E_WEST.Models.Academic
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Group> Groups { get; set; }
        public ICollection<TeacherDepartment> TeacherDepartments { get; set; }
    }
}
