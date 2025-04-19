using Microsoft.AspNetCore.Identity;

namespace E_WEST.Models
{
    // Расширение пользователя
    public class User : IdentityUser
    {

        public string FullName { get; set; } // ФИО
        public bool IsTwoFactorEnabled { get; set; } = false; // есть ли 2FA

    }
    public enum UserRole
    {
        Student,
        Teacher,
        Cpecialist,
        Manager,
        Admin
    }

}
