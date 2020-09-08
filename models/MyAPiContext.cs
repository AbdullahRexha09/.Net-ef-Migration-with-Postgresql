using Microsoft.EntityFrameworkCore;
namespace MyWebAPi.models
{
    public class MyAPiContext : DbContext
    {
        public MyAPiContext(DbContextOptions<MyAPiContext> options):base (options)
        {

        }
        public DbSet<User> User {get;set;}
        
    }
}