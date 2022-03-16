using AutoMapper;

/// <summary>
/// Mapper for 'Temporada' DTO - Entity
/// </summary>

public class TemporadaProfile : Profile
{
    public TemporadaProfile()
    {
        CreateMap<TemporadaDTO, TemporadaEntity>();
        CreateMap<TemporadaEntity, TemporadaDTO>();
        CreateMap<BaseTemporadaDTO, TemporadaEntity>();
        CreateMap<TemporadaEntity, BaseTemporadaDTO>();
    }
}
