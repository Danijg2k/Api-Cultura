using AutoMapper;

/// <summary>
/// Mapper for 'Opinion' DTO - Entity
/// </summary>

public class OpinionProfile : Profile
{
    public OpinionProfile()
    {
        CreateMap<OpinionDTO, OpinionEntity>();
        CreateMap<OpinionEntity, OpinionDTO>();
        CreateMap<BaseOpinionDTO, OpinionEntity>();
        CreateMap<OpinionEntity, BaseOpinionDTO>();
    }
}
