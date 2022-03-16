using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// 'Pertenece' entity
/// </summary>

[Table("Pertenece")]
public class PerteneceEntity
{

    public int IdProducto { get; set; }
    public int IdTemporada { get; set; }
    public int Id { get; set; }

}
