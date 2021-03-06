using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// 'Proveedor' entity
/// </summary>

[Table("Proveedores")]
public class ProveedorEntity
{

    [MaxLength(100)]
    public string Nombre { get; set; }
    [MaxLength(75)]
    public string Poblacion { get; set; }
    [MaxLength(30)]
    public string Telefono { get; set; }
    public int Id { get; set; }

}
