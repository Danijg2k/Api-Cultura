using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PertenenciasController : ControllerBase
{
    private readonly ILogger<PertenenciasController> _logger;
    private readonly IPerteneceService _perteneceService;


    /// <summary>
    /// It creates a pertenenciaController
    /// </summary>
    /// <param name="logger">used for logging</param>
    /// <param name="perteneceService">used for dealing with the pertenencia data</param>
    public PertenenciasController(ILogger<PertenenciasController> logger, IPerteneceService perteneceService)
    {
        _logger = logger;
        _perteneceService = perteneceService;
    }


    // Usado para mostrar info de ambas tablas (producto y temporada) una vez dentro de las temporadas

    /// <summary>
    /// Returns all the Pertenece by IdTemporada
    /// </summary>
    /// <param name="IdTemporada">the id of the temporada</param>
    /// <returns>Returns a list of <see cref="PerteneceDTO"/></returns>
    [HttpGet("{IdTemporada}/detail")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PerteneceDTO))]
    public ActionResult<PerteneceDTO> GetPerteneceTemporadaActual(int IdTemporada)
    {
        return Ok(_perteneceService.GetPerteneceDetail(IdTemporada));
    }
}
