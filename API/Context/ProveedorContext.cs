using System.Data.Entity;

public class ProveedorContext : DbContext
{
    public ProveedorContext(string connectionString) : base(connectionString)
    { }
    public DbSet<ProveedorEntity> Proveedores { get; set; }


    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
