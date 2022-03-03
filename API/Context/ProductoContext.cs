using System.Data.Entity;

public class ProductoContext : DbContext
{
    public ProductoContext(string connectionString) : base(connectionString)
    { }
    public DbSet<ProductoEntity> Productos { get; set; }


    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
