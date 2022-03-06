using System.Data.Entity;

public class TiendaContext : DbContext
{
    public TiendaContext(string connectionString) : base(connectionString)
    { }

    public DbSet<OpinionEntity> Opiniones { get; set; }
    public DbSet<PerteneceEntity> Pertenencias { get; set; }
    public DbSet<ProductoEntity> Productos { get; set; }
    public DbSet<ProveeEntity> Provisiones { get; set; }
    public DbSet<ProveedorEntity> Proveedores { get; set; }
    public DbSet<TemporadaEntity> Temporadas { get; set; }


    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
