/// <summary>
/// Base DTO of 'Pertenece', used in creation
/// </summary>

public class BasePerteneceDTO
{
    // Para relacionar con las dos tablas que une
    public int IdProducto { get; set; }
    public int IdTemporada { get; set; }
    // Producto
    public string NombreProducto { get; set; }
    public string ImgProducto { get; set; }
    // Temporada
    public string NombreTemporada { get; set; }
    public string ImgTemporada { get; set; }
    public string Meses { get; set; }
}