using AutoMapper;

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
