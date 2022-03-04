using System.Data.Entity;

public class ProveeContext : DbContext
{
    public ProveeContext(string connectionString) : base(connectionString)
    { }
    public DbSet<ProveeEntity> Provisiones { get; set; }


    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
