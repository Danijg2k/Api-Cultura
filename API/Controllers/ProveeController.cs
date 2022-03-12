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


    // Usado para mostrar info de ambas tablas (producto y proveedor)
    [HttpGet("{IdProducto}/detail")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProveeDTO))]
    public ActionResult<ProveeDTO> GetProveeProductoActual(int IdProducto)
    {
        return Ok(_proveeService.GetProveeDetail(IdProducto));
    }

}
