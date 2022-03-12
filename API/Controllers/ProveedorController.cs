using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProveedoresController : ControllerBase
{
    private readonly ILogger<ProveedoresController> _logger;
    private readonly IProveedorService _proveedorService;

    public ProveedoresController(ILogger<ProveedoresController> logger, IProveedorService proveedorService)
    {
        _logger = logger;
        _proveedorService = proveedorService;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProveedorDTO))]
    public ActionResult<ProveedorDTO> Get()
    {
        return Ok(_proveedorService.GetAll());
    }


    [HttpGet("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProveedorDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<ProveedorDTO> Get(int Id)
    {
        ProveedorDTO result = _proveedorService.GetByID(Id);

        if (result == null)
            return NotFound();

        return Ok(result);

    }


    [HttpDelete("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProveedorDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<ProveedorDTO> Delete(int Id)
    {
        ProveedorDTO result = _proveedorService.GetByID(Id);

        if (result == null)
            return NotFound();

        _proveedorService.Delete(Id);

        return Ok(result);

    }



    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProveedorDTO))]
    public ActionResult<ProveedorDTO> Post([FromBody] BaseProveedorDTO baseProveedor)
    {

        return Ok(_proveedorService.Add(baseProveedor));
    }

    [HttpPut("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProveedorDTO))]
    public ActionResult<ProveedorDTO> Put([FromBody] BaseProveedorDTO baseProveedor, int Id)
    {

        return Ok(_proveedorService.Modify(baseProveedor, Id));
    }

}
