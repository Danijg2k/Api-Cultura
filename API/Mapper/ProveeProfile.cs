using AutoMapper;

/// <summary>
/// Mapper for 'Provee' DTO - Entity
/// </summary>

public class ProveeProfile : Profile
{
    public ProveeProfile()
    {
        CreateMap<ProveeDTO, ProveeEntity>();
        CreateMap<ProveeEntity, ProveeDTO>();
        CreateMap<BaseProveeDTO, ProveeEntity>();
        CreateMap<ProveeEntity, BaseProveeDTO>();
    }
}
