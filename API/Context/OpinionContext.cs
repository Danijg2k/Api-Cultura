using System.Data.Entity;

public class OpinionContext : DbContext
{
    public OpinionContext(string connectionString) : base(connectionString)
    { }
    public DbSet<OpinionEntity> Opiniones { get; set; }


    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
