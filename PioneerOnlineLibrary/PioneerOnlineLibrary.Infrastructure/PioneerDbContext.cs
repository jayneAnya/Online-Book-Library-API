using Microsoft.EntityFrameworkCore;
using PioneerOnlineLibrary.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerOnlineLibrary.Infrastructure
{
    public class PioneerDbContext : DbContext
    {
        public PioneerDbContext(DbContextOptions<PioneerDbContext> option) : base(option)
        {

        }

        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Review> Reviews { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<BookCategory> BookCategories { get; set; } = null!;
    }
}
