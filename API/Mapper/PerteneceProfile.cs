using AutoMapper;

/// <summary>
/// Mapper for 'Pertenece' DTO - Entity
/// </summary>

public class PerteneceProfile : Profile
{
    public PerteneceProfile()
    {
        CreateMap<PerteneceDTO, PerteneceEntity>();
        CreateMap<PerteneceEntity, PerteneceDTO>();
        CreateMap<BasePerteneceDTO, PerteneceEntity>();
        CreateMap<PerteneceEntity, BasePerteneceDTO>();
    }
}
