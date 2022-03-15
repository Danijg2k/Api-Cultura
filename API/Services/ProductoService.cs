using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

/// <summary>
/// 'Producto' service
/// </summary>

public class ProductoService : IProductoService
{
    private readonly TiendaContext _context;
    private readonly IMapper _mapper;

    public ProductoService(TiendaContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    // public ProductoDTO Add(BaseProductoDTO baseProducto)
    // {
    //     var _mappedProducto = _mapper.Map<ProductoEntity>(baseProducto);
    //     var entityAdded = _context.Productos.Add(_mappedProducto);
    //     _context.SaveChanges();
    //     return _mapper.Map<ProductoDTO>(entityAdded);
    // }

    // public void Delete(int guid)
    // {
    //     ProductoEntity product = _context.Productos.FirstOrDefault(x => x.Id == guid);

    //     if (product == null)
    //         throw new ApplicationException($"Product with id {guid} not found");

    //     _context.Productos.Remove(product);
    //     _context.SaveChanges();
    // }

    public IEnumerable<ProductoDTO> GetAll()
    {
        return _mapper.Map<IEnumerable<ProductoDTO>>(_context.Productos.Select(x => x));
    }

    // public ProductoDTO GetByID(int guid)
    // {
    //     return _mapper.Map<ProductoDTO>(_context.Productos.FirstOrDefault(x => x.Id == guid));
    // }

    // public ProductoDTO Modify(BaseProductoDTO product, int guid)
    // {
    //     var _mappedProducto = _mapper.Map<ProductoEntity>(product);
    //     _mappedProducto.Id = guid;

    //     ProductoEntity modifiedProducto = _context.Productos.FirstOrDefault(x => x.Id == guid);

    //     if (modifiedProducto == null)
    //         return null;

    //     _context.Entry(modifiedProducto).CurrentValues.SetValues(_mappedProducto);

    //     _context.SaveChanges();

    //     return _mapper.Map<ProductoDTO>(_mappedProducto);
    // }

}