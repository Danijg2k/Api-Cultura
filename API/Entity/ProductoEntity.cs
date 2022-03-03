using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Productos")]
public class ProductoEntity
{

    [MaxLength(100)]
    public string Nombre { get; set; }
    [MaxLength(200)]
    public string Img { get; set; }

    public int Id { get; set; }

}
