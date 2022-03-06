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

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PerteneceDTO))]
    public ActionResult<PerteneceDTO> Get()
    {
        return Ok(_perteneceService.GetAll());
    }

    [HttpGet("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PerteneceDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<PerteneceDTO> Get(int Id)
    {
        PerteneceDTO result = _perteneceService.GetByID(Id);

        if (result == null)
            return NotFound();

        return Ok(result);

    }


    [HttpDelete("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PerteneceDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<PerteneceDTO> Delete(int Id)
    {
        PerteneceDTO result = _perteneceService.GetByID(Id);

        if (result == null)
            return NotFound();

        _perteneceService.Delete(Id);

        return Ok(result);

    }



    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PerteneceDTO))]
    public ActionResult<PerteneceDTO> Post([FromBody] BasePerteneceDTO basePertenece)
    {

        return Ok(_perteneceService.Add(basePertenece));
    }

    [HttpPut("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PerteneceDTO))]
    public ActionResult<PerteneceDTO> Put([FromBody] BasePerteneceDTO basePertenece, int Id)
    {

        return Ok(_perteneceService.Modify(basePertenece, Id));
    }

}
