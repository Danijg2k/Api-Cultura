using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Provee")]
public class ProveeEntity
{

    public int IdProducto { get; set; }
    public int IdProveedor { get; set; }
    public decimal Precio { get; set; }
    public int Id { get; set; }

}
