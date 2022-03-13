using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TemporadasController : ControllerBase
{
    private readonly ILogger<TemporadasController> _logger;
    private readonly ITemporadaService _temporadaService;


    /// <summary>
    /// It creates a temporadaController
    /// </summary>
    /// <param name="logger">used for logging</param>
    /// <param name="temporadaService">used for dealing with the temporada data</param>
    public TemporadasController(ILogger<TemporadasController> logger, ITemporadaService temporadaService)
    {
        _logger = logger;
        _temporadaService = temporadaService;
    }


    /// <summary>
    /// Returns all the Temporadas
    /// </summary>
    /// <returns>Returns a list of <see cref="TemporadaDTO"/></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TemporadaDTO))]
    public ActionResult<TemporadaDTO> Get()
    {
        return Ok(_temporadaService.GetAll());
    }

    // [HttpGet("{Id}")]
    // [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TemporadaDTO))]
    // [ProducesResponseType(StatusCodes.Status404NotFound)]
    // public ActionResult<TemporadaDTO> Get(int Id)
    // {
    //     TemporadaDTO result = _temporadaService.GetByID(Id);

    //     if (result == null)
    //         return NotFound();

    //     return Ok(result);

    // }


    // [HttpDelete("{Id}")]
    // [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TemporadaDTO))]
    // [ProducesResponseType(StatusCodes.Status404NotFound)]
    // public ActionResult<TemporadaDTO> Delete(int Id)
    // {
    //     TemporadaDTO result = _temporadaService.GetByID(Id);

    //     if (result == null)
    //         return NotFound();

    //     _temporadaService.Delete(Id);

    //     return Ok(result);

    // }



    // [HttpPost]
    // [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TemporadaDTO))]
    // public ActionResult<TemporadaDTO> Post([FromBody] BaseTemporadaDTO baseTemporada)
    // {

    //     return Ok(_temporadaService.Add(baseTemporada));
    // }

    // [HttpPut("{Id}")]
    // [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TemporadaDTO))]
    // public ActionResult<TemporadaDTO> Put([FromBody] BaseTemporadaDTO baseTemporada, int Id)
    // {

    //     return Ok(_temporadaService.Modify(baseTemporada, Id));
    // }

}
