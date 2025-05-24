using Microsoft.EntityFrameworkCore;
using CRUD_APP.Model;

namespace CRUD_APP.Data
{
    public class CRUD_APPContext : DbContext
    {
        public CRUD_APPContext(DbContextOptions<CRUD_APPContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}