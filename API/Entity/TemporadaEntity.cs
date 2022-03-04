using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Temporadas")]
public class TemporadaEntity
{

    [MaxLength(100)]
    public string Nombre { get; set; }
    [MaxLength(75)]
    public string Img { get; set; }
    public string Meses { get; set; }
    public int Id { get; set; }

}
