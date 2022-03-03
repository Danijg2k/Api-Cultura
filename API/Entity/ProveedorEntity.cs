using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Proveedores")]
public class ProveedorEntity
{

    [MaxLength(100)]
    public string Nombre { get; set; }
    [MaxLength(75)]
    public string Poblacion { get; set; }
    public int Telefono { get; set; }
    public int Id { get; set; }

}
