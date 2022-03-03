using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductosController : ControllerBase
{
    private readonly ILogger<ProductosController> _logger;
    private readonly IProductoService _productoService;

    public ProductosController(ILogger<ProductosController> logger, IProductoService productoService)
    {
        _logger = logger;
        _productoService = productoService;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductoDTO))]
    public ActionResult<ProductoDTO> Get()
    {
        return Ok(_productoService.GetAll());
    }

    [HttpGet("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductoDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<ProductoDTO> Get(int Id)
    {
        ProductoDTO result = _productoService.GetByID(Id);

        if (result == null)
            return NotFound();

        return Ok(result);

    }


    [HttpDelete("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductoDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<ProductoDTO> Delete(int Id)
    {
        ProductoDTO result = _productoService.GetByID(Id);

        if (result == null)
            return NotFound();

        _productoService.Delete(Id);

        return Ok(result);

    }



    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductoDTO))]
    public ActionResult<ProductoDTO> Post([FromBody] BaseProductoDTO baseProducto)
    {

        return Ok(_productoService.Add(baseProducto));
    }

    [HttpPut("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductoDTO))]
    public ActionResult<ProductoDTO> Put([FromBody] BaseProductoDTO baseProducto, int Id)
    {

        return Ok(_productoService.Modify(baseProducto, Id));
    }

}
