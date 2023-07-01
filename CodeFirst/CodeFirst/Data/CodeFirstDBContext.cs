using CodeFirst.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Data
{
    public class CodeFirstDBContext: DbContext
    {
        public CodeFirstDBContext(DbContextOptions<CodeFirstDBContext> options) : base(options)
        {
            
        }

        //Entity Framework
        //Mean please create Regions table for use table does not exit
        public DbSet<Region> Regions { get; set; } //Domain Region , db table name Regions , DbSet able to use Entity Framework to query
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulties { get; set; } //WalkDifficulty got s  WalkDifficulties
    }
}
