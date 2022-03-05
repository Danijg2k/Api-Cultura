using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Temporadas")]
public class TemporadaEntity
{

    [MaxLength(100)]
    public string Nombre { get; set; }
    [MaxLength(200)]
    public string Img { get; set; }
    [MaxLength(50)]
    public string Meses { get; set; }
    public int Id { get; set; }

}
