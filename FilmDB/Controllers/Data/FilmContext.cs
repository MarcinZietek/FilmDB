using FilmDB.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmDB.Controllers.Data
{
    public class FilmContext : DbContext
    {
        public FilmContext(DbContextOptions<FilmContext> options)
            : base(options)
        {
        }
        public DbSet<FilmModel> Films { get; set; }
    }
}
