using Microsoft.EntityFrameworkCore;

namespace StarChart.Data
{
    public classApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
