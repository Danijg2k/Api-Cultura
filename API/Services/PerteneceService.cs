using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

public class PerteneceService : IPerteneceService
{
    private readonly TiendaContext _context;
    private readonly IMapper _mapper;

    public PerteneceService(TiendaContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    // Usado para mostrar info de ambas tablas (producto y temporada) una vez dentro de las temporadas
    public IEnumerable<PerteneceDTO> GetPerteneceDetail(int guid)
    {
        return (from pertenece in _context.Pertenencias
                join producto in _context.Productos on pertenece.IdProducto equals producto.Id
                join temporada in _context.Temporadas on pertenece.IdTemporada equals temporada.Id
                where temporada.Id == guid
                select new PerteneceDTO
                {
                    IdProducto = producto.Id,
                    IdTemporada = temporada.Id,
                    NombreProducto = producto.Nombre,
                    ImgProducto = producto.Img,
                    NombreTemporada = temporada.Nombre,
                    ImgTemporada = temporada.Img,
                    Meses = temporada.Meses
                });
    }

}