using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

public class ProveedorService : IProveedorService
{
    private readonly ProveedorContext _context;
    private readonly IMapper _mapper;
    // Introducido
    private readonly ProveeContext _context1;

    public ProveedorService(ProveedorContext context, IMapper mapper, ProveeContext context1)
    {
        _context = context;
        _mapper = mapper;
        _context1 = context1;
    }

    public ProveedorDTO Add(BaseProveedorDTO baseProveedor)
    {
        var _mappedProveedor = _mapper.Map<ProveedorEntity>(baseProveedor);
        var entityAdded = _context.Proveedores.Add(_mappedProveedor);
        _context.SaveChanges();
        return _mapper.Map<ProveedorDTO>(entityAdded);
    }

    public void Delete(int guid)
    {
        ProveedorEntity proveedor = _context.Proveedores.FirstOrDefault(x => x.Id == guid);

        if (proveedor == null)
            throw new ApplicationException($"Provider with id {guid} not found");

        _context.Proveedores.Remove(proveedor);
        _context.SaveChanges();
    }

    public IEnumerable<ProveedorDTO> GetAll()
    {
        return _mapper.Map<IEnumerable<ProveedorDTO>>(_context.Proveedores.Select(x => x));
    }


    // Método que vamos a utilizar para mostrar proveedores del producto actual en nuestra WEB.
    //_context.Provisiones.Where(x => x.IdProducto == guid)
    // Pasar el array de ProveeDTO[] a un array que solo tenga las id
    // public IEnumerable<ProveedorDTO> GetAllOfProduct(ProveeDTO[] provisiones)
    // {
    //     return _mapper.Map<IEnumerable<ProveedorDTO>>(_context.Proveedores.Select(x => provisiones.Contains));
    // }


    public ProveedorDTO GetByID(int guid)
    {
        return _mapper.Map<ProveedorDTO>(_context.Proveedores.FirstOrDefault(x => x.Id == guid));
    }

    public ProveedorDTO Modify(BaseProveedorDTO proveedor, int guid)
    {
        var _mappedProveedor = _mapper.Map<ProveedorEntity>(proveedor);
        _mappedProveedor.Id = guid;

        ProveedorEntity modifiedProveedor = _context.Proveedores.FirstOrDefault(x => x.Id == guid);

        if (modifiedProveedor == null)
            return null;

        _context.Entry(modifiedProveedor).CurrentValues.SetValues(_mappedProveedor);

        _context.SaveChanges();

        return _mapper.Map<ProveedorDTO>(_mappedProveedor);
    }

}