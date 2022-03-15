/// <summary>
/// Base DTO of 'Provee', used in creation
/// </summary>

public class BaseProveeDTO
{
    // Para relacionar con las dos tablas que une
    public int IdProducto { get; set; }
    public int IdProveedor { get; set; }
    // Resto atributos
    public decimal Precio { get; set; }
    // Producto
    public string NombreProducto { get; set; }
    public string Img { get; set; }
    // Proveedor
    public string NombreProveedor { get; set; }
    public string Poblacion { get; set; }
    public string Telefono { get; set; }
}