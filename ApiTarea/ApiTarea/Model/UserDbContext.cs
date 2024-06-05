using Microsoft.EntityFrameworkCore;

namespace ApiTarea.Model
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-EPTCBBPO\\SQLSERVER;Initial Catalog=TareaAnalisis;User ID=sa;Password=1234;");
        }
    }

}
