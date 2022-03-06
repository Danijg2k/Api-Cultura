using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

public class ProveedorService : IProveedorService
{
    private readonly TiendaContext _context;
    private readonly IMapper _mapper;

    public ProveedorService(TiendaContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
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
    public IEnumerable<ProveedorDTO> GetAllOfProduct(int[] idProveedores)
    {
        return _mapper.Map<IEnumerable<ProveedorDTO>>(_context.Proveedores.Select(x => idProveedores.Contains(x.Id)));
    }


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