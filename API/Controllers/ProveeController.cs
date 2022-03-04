using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProvisionesController : ControllerBase
{
    private readonly ILogger<ProvisionesController> _logger;
    private readonly IProductoService _proveeService;

    public ProvisionesController(ILogger<ProvisionesController> logger, IProductoService proveeService)
    {
        _logger = logger;
        _proveeService = proveeService;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductoDTO))]
    public ActionResult<ProductoDTO> Get()
    {
        return Ok(_proveeService.GetAll());
    }

    [HttpGet("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductoDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<ProductoDTO> Get(int Id)
    {
        ProductoDTO result = _proveeService.GetByID(Id);

        if (result == null)
            return NotFound();

        return Ok(result);

    }


    [HttpDelete("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductoDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<ProductoDTO> Delete(int Id)
    {
        ProductoDTO result = _proveeService.GetByID(Id);

        if (result == null)
            return NotFound();

        _proveeService.Delete(Id);

        return Ok(result);

    }



    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductoDTO))]
    public ActionResult<ProductoDTO> Post([FromBody] BaseProductoDTO baseProducto)
    {

        return Ok(_proveeService.Add(baseProducto));
    }

    [HttpPut("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductoDTO))]
    public ActionResult<ProductoDTO> Put([FromBody] BaseProductoDTO baseProducto, int Id)
    {

        return Ok(_proveeService.Modify(baseProducto, Id));
    }

}
