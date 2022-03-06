using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

public class TemporadaService : ITemporadaService
{
    private readonly TiendaContext _context;
    private readonly IMapper _mapper;

    public TemporadaService(TiendaContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public TemporadaDTO Add(BaseTemporadaDTO baseTemporada)
    {
        var _mappedTemporada = _mapper.Map<TemporadaEntity>(baseTemporada);
        var entityAdded = _context.Temporadas.Add(_mappedTemporada);
        _context.SaveChanges();
        return _mapper.Map<TemporadaDTO>(entityAdded);
    }

    public void Delete(int guid)
    {
        TemporadaEntity temporada = _context.Temporadas.FirstOrDefault(x => x.Id == guid);

        if (temporada == null)
            throw new ApplicationException($"Season with id {guid} not found");

        _context.Temporadas.Remove(temporada);
        _context.SaveChanges();
    }

    public IEnumerable<TemporadaDTO> GetAll()
    {
        return _mapper.Map<IEnumerable<TemporadaDTO>>(_context.Temporadas.Select(x => x));
    }

    public TemporadaDTO GetByID(int guid)
    {
        return _mapper.Map<TemporadaDTO>(_context.Temporadas.FirstOrDefault(x => x.Id == guid));
    }

    public TemporadaDTO Modify(BaseTemporadaDTO temporada, int guid)
    {
        var _mappedTemporada = _mapper.Map<TemporadaEntity>(temporada);
        _mappedTemporada.Id = guid;

        TemporadaEntity modifiedTemporada = _context.Temporadas.FirstOrDefault(x => x.Id == guid);

        if (modifiedTemporada == null)
            return null;

        _context.Entry(modifiedTemporada).CurrentValues.SetValues(_mappedTemporada);

        _context.SaveChanges();

        return _mapper.Map<TemporadaDTO>(_mappedTemporada);
    }

}