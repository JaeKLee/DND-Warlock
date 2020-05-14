using Microsoft.EntityFrameworkCore;

namespace DND_Warlock.Data {
    public class DND_WarlockContext : DbContext {
        public DND_WarlockContext(
            DbContextOptions<DND_WarlockContext> options)
            : base(options) {

            }

        public DbSet<DND_Warlock.Models.Movie> Movie { get; set; }
    }
}