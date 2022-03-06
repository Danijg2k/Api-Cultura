using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

public class ProveeService : IProveeService
{
    private readonly TiendaContext _context;
    private readonly IMapper _mapper;

    public ProveeService(TiendaContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public ProveeDTO Add(BaseProveeDTO baseProvee)
    {
        var _mappedProvee = _mapper.Map<ProveeEntity>(baseProvee);
        var entityAdded = _context.Provisiones.Add(_mappedProvee);
        _context.SaveChanges();
        return _mapper.Map<ProveeDTO>(entityAdded);
    }

    public void Delete(int guid)
    {
        ProveeEntity provision = _context.Provisiones.FirstOrDefault(x => x.Id == guid);

        if (provision == null)
            throw new ApplicationException($"Provision with id {guid} not found");

        _context.Provisiones.Remove(provision);
        _context.SaveChanges();
    }

    public IEnumerable<ProveeDTO> GetAll()
    {
        return _mapper.Map<IEnumerable<ProveeDTO>>(_context.Provisiones.Select(x => x));
    }

    // Seguramente no va a ser utilizado, introducido para realizar pruebas.
    public IEnumerable<ProveeDTO> GetAllOfProduct(int guid)
    {
        return _mapper.Map<IEnumerable<ProveeDTO>>(_context.Provisiones.Where(x => x.IdProducto == guid));
    }

    public ProveeDTO GetByID(int guid)
    {
        return _mapper.Map<ProveeDTO>(_context.Provisiones.FirstOrDefault(x => x.Id == guid));
    }

    public ProveeDTO Modify(BaseProveeDTO provision, int guid)
    {
        var _mappedProvee = _mapper.Map<ProveeEntity>(provision);
        _mappedProvee.Id = guid;

        ProveeEntity modifiedProvee = _context.Provisiones.FirstOrDefault(x => x.Id == guid);

        if (modifiedProvee == null)
            return null;

        _context.Entry(modifiedProvee).CurrentValues.SetValues(_mappedProvee);

        _context.SaveChanges();

        return _mapper.Map<ProveeDTO>(_mappedProvee);
    }

}