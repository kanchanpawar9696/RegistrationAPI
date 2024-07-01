using ClassAPI.MODEL;
using Microsoft.EntityFrameworkCore;

namespace RegistrationAPI.DATA
{
    public class LoginModelDBContext:DbContext
    {
        public LoginModelDBContext(DbContextOptions<LoginModelDBContext> options) : base(options) { }
        public DbSet<LoginModel> UserInformation { get; set; }
    }
}
