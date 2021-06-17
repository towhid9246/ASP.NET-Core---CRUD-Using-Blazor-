using Microsoft.EntityFrameworkCore;
namespace Trust.Data
{
    public class AppContext : DbContext
    {
        public AppContext() { }
        public AppContext(DbContextOptions<AppContext> options) :
              base(options)
        { }
    }
}