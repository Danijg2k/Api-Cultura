using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

public class PerteneceService : IPerteneceService
{
    private readonly PerteneceContext _context;
    private readonly IMapper _mapper;

    public PerteneceService(PerteneceContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public PerteneceDTO Add(BasePerteneceDTO basePertenece)
    {
        var _mappedPertenece = _mapper.Map<PerteneceEntity>(basePertenece);
        var entityAdded = _context.Pertenencias.Add(_mappedPertenece);
        _context.SaveChanges();
        return _mapper.Map<PerteneceDTO>(entityAdded);
    }

    public void Delete(int guid)
    {
        PerteneceEntity pertenencia = _context.Pertenencias.FirstOrDefault(x => x.Id == guid);

        if (pertenencia == null)
            throw new ApplicationException($"Belonging with id {guid} not found");

        _context.Pertenencias.Remove(pertenencia);
        _context.SaveChanges();
    }

    public IEnumerable<PerteneceDTO> GetAll()
    {
        return _mapper.Map<IEnumerable<PerteneceDTO>>(_context.Pertenencias.Select(x => x));
    }

    public PerteneceDTO GetByID(int guid)
    {
        return _mapper.Map<PerteneceDTO>(_context.Pertenencias.FirstOrDefault(x => x.Id == guid));
    }

    public PerteneceDTO Modify(BasePerteneceDTO pertenencia, int guid)
    {
        var _mappedPertenece = _mapper.Map<PerteneceEntity>(pertenencia);
        _mappedPertenece.Id = guid;

        PerteneceEntity modifiedPertenece = _context.Pertenencias.FirstOrDefault(x => x.Id == guid);

        if (modifiedPertenece == null)
            return null;

        _context.Entry(modifiedPertenece).CurrentValues.SetValues(_mappedPertenece);

        _context.SaveChanges();

        return _mapper.Map<PerteneceDTO>(_mappedPertenece);
    }

}