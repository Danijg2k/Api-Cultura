using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

/// <summary>
/// 'Provee' service
/// </summary>

public class ProveeService : IProveeService
{
    private readonly TiendaContext _context;
    private readonly IMapper _mapper;

    public ProveeService(TiendaContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    // Usado para poder mostrar cada producto junto a su precio, ya que se encuentran en tablas diferentes (producto, provee)
    public IEnumerable<ProveeDTO> GetProveeDetail()
    {
        return (from provee in _context.Provisiones
                join producto in _context.Productos on provee.IdProducto equals producto.Id
                select new ProveeDTO
                {
                    IdProducto = producto.Id,
                    Precio = provee.Precio,
                    NombreProducto = producto.Nombre,
                    Img = producto.Img,
                });
    }


    // Usado para mostrar info de ambas tablas (producto y proveedor)
    public IEnumerable<ProveeDTO> GetProveeDetail(int guid)
    {
        return (from provee in _context.Provisiones
                join producto in _context.Productos on provee.IdProducto equals producto.Id
                join proveedor in _context.Proveedores on provee.IdProveedor equals proveedor.Id
                where producto.Id == guid
                select new ProveeDTO
                {
                    IdProducto = producto.Id,
                    IdProveedor = proveedor.Id,
                    Precio = provee.Precio,
                    NombreProducto = producto.Nombre,
                    Img = producto.Img,
                    NombreProveedor = proveedor.Nombre,
                    Poblacion = proveedor.Poblacion,
                    Telefono = proveedor.Telefono
                });
    }


}