using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProvisionesController : ControllerBase
{
    private readonly ILogger<ProvisionesController> _logger;
    private readonly IProveeService _proveeService;

    public ProvisionesController(ILogger<ProvisionesController> logger, IProveeService proveeService)
    {
        _logger = logger;
        _proveeService = proveeService;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProveeDTO))]
    public ActionResult<ProveeDTO> Get()
    {
        return Ok(_proveeService.GetAll());
    }

    [HttpGet("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProveeDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<ProveeDTO> Get(int Id)
    {
        ProveeDTO result = _proveeService.GetByID(Id);

        if (result == null)
            return NotFound();

        return Ok(result);

    }


    [HttpDelete("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProveeDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<ProveeDTO> Delete(int Id)
    {
        ProveeDTO result = _proveeService.GetByID(Id);

        if (result == null)
            return NotFound();

        _proveeService.Delete(Id);

        return Ok(result);

    }



    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProveeDTO))]
    public ActionResult<ProveeDTO> Post([FromBody] BaseProveeDTO baseProvee)
    {

        return Ok(_proveeService.Add(baseProvee));
    }

    [HttpPut("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProveeDTO))]
    public ActionResult<ProveeDTO> Put([FromBody] BaseProveeDTO baseProvee, int Id)
    {

        return Ok(_proveeService.Modify(baseProvee, Id));
    }

}
