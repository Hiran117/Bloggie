using Bloggie.web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Bloggie.web.Data
{
    public class BloggieDbContext : DbContext
    {
        public BloggieDbContext(DbContextOptions options) : base(options)
        {
        }
        //create tables using entity frame work core
        public DbSet<BlogPost> blogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
