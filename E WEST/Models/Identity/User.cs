using Microsoft.AspNetCore.Identity;

namespace E_WEST.Models.Identity
{
    // Расширение пользователя
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public string CorporateEmail { get; set; } // Иванов-ii@ranepa.ru
        public bool IsEmployee { get; set; } // true для преподавателей/админов
    }
}