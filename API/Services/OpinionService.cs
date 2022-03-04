using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

public class OpinionService : IOpinionService
{
    private readonly OpinionContext _context;
    private readonly IMapper _mapper;

    public OpinionService(OpinionContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public OpinionDTO Add(BaseOpinionDTO baseOpinion)
    {
        var _mappedOpinion = _mapper.Map<OpinionEntity>(baseOpinion);
        var entityAdded = _context.Opiniones.Add(_mappedOpinion);
        _context.SaveChanges();
        return _mapper.Map<OpinionDTO>(entityAdded);
    }

    public void Delete(int guid)
    {
        OpinionEntity opinion = _context.Opiniones.FirstOrDefault(x => x.Id == guid);

        if (opinion == null)
            throw new ApplicationException($"Opinion with id {guid} not found");

        _context.Opiniones.Remove(opinion);
        _context.SaveChanges();
    }

    public IEnumerable<OpinionDTO> GetAll()
    {
        return _mapper.Map<IEnumerable<OpinionDTO>>(_context.Opiniones.Select(x => x));
    }

    public OpinionDTO GetByID(int guid)
    {
        return _mapper.Map<OpinionDTO>(_context.Opiniones.FirstOrDefault(x => x.Id == guid));
    }

    public OpinionDTO Modify(BaseOpinionDTO opinion, int guid)
    {
        var _mappedOpinion = _mapper.Map<OpinionEntity>(opinion);
        _mappedOpinion.Id = guid;

        OpinionEntity modifiedOpinion = _context.Opiniones.FirstOrDefault(x => x.Id == guid);

        if (modifiedOpinion == null)
            return null;

        _context.Entry(modifiedOpinion).CurrentValues.SetValues(_mappedOpinion);

        _context.SaveChanges();

        return _mapper.Map<OpinionDTO>(_mappedOpinion);
    }

}