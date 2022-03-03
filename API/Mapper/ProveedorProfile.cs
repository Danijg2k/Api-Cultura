using AutoMapper;

public class ProveedorProfile : Profile
{
    public ProveedorProfile()
    {
        CreateMap<ProveedorDTO, ProveedorEntity>();
        CreateMap<ProveedorEntity, ProveedorDTO>();
        CreateMap<BaseProveedorDTO, ProveedorEntity>();
        CreateMap<ProveedorEntity, BaseProveedorDTO>();
    }
}
