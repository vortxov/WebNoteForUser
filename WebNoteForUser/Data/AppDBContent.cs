using Microsoft.EntityFrameworkCore;
using WebNoteForUser.Data.Models;

namespace WebTest.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Note> Notes { get; set; }
        public DbSet<UserAccount> Users { get; set; }
    }
}
