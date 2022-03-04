using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Opiniones")]
public class OpinionEntity
{

    [MaxLength(100)]
    public string Nombre { get; set; }
    [MaxLength(75)]
    public string Apellidos { get; set; }
    public string Email { get; set; }
    public int Telefono { get; set; }
    public int Calificacion { get; set; }
    public string Comentario { get; set; }
    public int Id { get; set; }

}
