using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PertenenciasController : ControllerBase
{
    private readonly ILogger<PertenenciasController> _logger;
    private readonly IPerteneceService _perteneceService;

    public PertenenciasController(ILogger<PertenenciasController> logger, IPerteneceService perteneceService)
    {
        _logger = logger;
        _perteneceService = perteneceService;
    }


    // Usado para mostrar info de ambas tablas (producto y temporada) una vez dentro de las temporadas
    [HttpGet("{IdTemporada}/detail")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PerteneceDTO))]
    public ActionResult<PerteneceDTO> GetPerteneceTemporadaActual(int IdTemporada)
    {
        return Ok(_perteneceService.GetPerteneceDetail(IdTemporada));
    }
}
