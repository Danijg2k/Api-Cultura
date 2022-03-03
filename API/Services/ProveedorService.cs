using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

public class ProveedorService : IProveedorService
{
    private readonly ProveedorContext _context;
    private readonly IMapper _mapper;

    public ProveedorService(ProveedorContext context, IMapper mapper)
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
        ProveedorEntity product = _context.Proveedores.FirstOrDefault(x => x.Id == guid);

        if (product == null)
            throw new ApplicationException($"Provider with id {guid} not found");

        _context.Proveedores.Remove(product);
        _context.SaveChanges();
    }

    public IEnumerable<ProveedorDTO> GetAll()
    {
        return _mapper.Map<IEnumerable<ProveedorDTO>>(_context.Proveedores.Select(x => x));
    }

    public ProveedorDTO GetByID(int guid)
    {
        return _mapper.Map<ProveedorDTO>(_context.Proveedores.FirstOrDefault(x => x.Id == guid));
    }

    public ProveedorDTO Modify(BaseProveedorDTO product, int guid)
    {
        var _mappedProveedor = _mapper.Map<ProveedorEntity>(product);
        _mappedProveedor.Id = guid;

        ProveedorEntity modifiedProveedor = _context.Proveedores.FirstOrDefault(x => x.Id == guid);

        if (modifiedProveedor == null)
            return null;

        _context.Entry(modifiedProveedor).CurrentValues.SetValues(_mappedProveedor);

        _context.SaveChanges();

        return _mapper.Map<ProveedorDTO>(_mappedProveedor);
    }

}