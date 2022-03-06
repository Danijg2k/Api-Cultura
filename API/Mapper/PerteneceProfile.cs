using AutoMapper;

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
