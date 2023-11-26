using Microsoft.EntityFrameworkCore;

namespace paternProxy;
 
public class UserContext : DbContext
{
    public DbSet<UserInfo> Users { set; get; }
    public UserContext() => Database.EnsureCreated();
 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=users.db");
    }
}
