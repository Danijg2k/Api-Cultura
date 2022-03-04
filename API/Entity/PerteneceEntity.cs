using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Pertenece")]
public class PerteneceEntity
{

    public int IdProducto { get; set; }
    public int IdTemporada { get; set; }
    public int Id { get; set; }

}
