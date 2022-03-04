using System.Data.Entity;

public class TemporadaContext : DbContext
{
    public TemporadaContext(string connectionString) : base(connectionString)
    { }
    public DbSet<TemporadaEntity> Temporadas { get; set; }


    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
