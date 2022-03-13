using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProvisionesController : ControllerBase
{
    private readonly ILogger<ProvisionesController> _logger;
    private readonly IProveeService _proveeService;


    /// <summary>
    /// It creates a provisionController
    /// </summary>
    /// <param name="logger">used for logging</param>
    /// <param name="proveeService">used for dealing with the provision data</param>
    public ProvisionesController(ILogger<ProvisionesController> logger, IProveeService proveeService)
    {
        _logger = logger;
        _proveeService = proveeService;
    }


    // Usado para poder mostrar cada producto junto a su precio, ya que se encuentran en tablas diferentes (producto, provee)
    // Solo devuelve un registro con el precio más bajo, no uno por cada proveedor que suministra dicho producto -> TODO

    /// <summary>
    /// Returns all the Provee with just the info to show each product with its min price -> TODO 
    /// </summary>
    /// <returns>Returns a list of <see cref="ProveeDTO"/></returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProveeDTO))]
    public ActionResult<ProveeDTO> GetProveeProductoActual()
    {
        return Ok(_proveeService.GetProveeDetail());
    }


    // Usado para mostrar info de ambas tablas (producto y proveedor)

    /// <summary>
    /// Returns all the Provee by IdProducto
    /// </summary>
    /// <param name="IdProducto">the id of the producto</param>
    /// <returns>Returns a list of <see cref="ProveeDTO"/></returns>
    [HttpGet("{IdProducto}/detail")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProveeDTO))]
    public ActionResult<ProveeDTO> GetProveeProductoActual(int IdProducto)
    {
        return Ok(_proveeService.GetProveeDetail(IdProducto));
    }

}
