using AutoMapper;

public class ProductoProfile : Profile
{
    public ProductoProfile()
    {
        CreateMap<ProductoDTO, ProductoEntity>();
        CreateMap<ProductoEntity, ProductoDTO>();
        CreateMap<BaseProductoDTO, ProductoEntity>();
        CreateMap<ProductoEntity, BaseProductoDTO>();
    }
}
