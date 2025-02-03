using Microsoft.EntityFrameworkCore;

namespace BackstageTryout.Infrastructure;

public class BackstageTryoutDbContext : DbContext
{
    public BackstageTryoutDbContext(DbContextOptions<BackstageTryoutDbContext> options)
        : base(options) { }
}
