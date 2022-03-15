using AutoMapper;

/// <summary>
/// Mapper for 'Proveedor' DTO - Entity
/// </summary>

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
