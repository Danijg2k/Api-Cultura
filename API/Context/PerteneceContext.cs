using System.Data.Entity;

public class PerteneceContext : DbContext
{
    public PerteneceContext(string connectionString) : base(connectionString)
    { }
    public DbSet<PerteneceEntity> Pertenencias { get; set; }


    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
