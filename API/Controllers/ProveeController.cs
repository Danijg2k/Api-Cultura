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


    // Usado para poder mostrar cada producto junto a su precio, ya que se encuentran en tablas diferentes (producto, provee)
    // Solo devuelve un registro con el precio más bajo, no uno por cada proveedor que suministra dicho producto
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProveeDTO))]
    public ActionResult<ProveeDTO> GetProveeProductoActual()
    {
        return Ok(_proveeService.GetProveeDetail());
    }


    // Usado para mostrar info de ambas tablas (producto y proveedor)
    [HttpGet("{IdProducto}/detail")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProveeDTO))]
    public ActionResult<ProveeDTO> GetProveeProductoActual(int IdProducto)
    {
        return Ok(_proveeService.GetProveeDetail(IdProducto));
    }

}
