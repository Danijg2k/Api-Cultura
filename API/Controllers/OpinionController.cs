using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class OpinionesController : ControllerBase
{
    private readonly ILogger<OpinionesController> _logger;
    private readonly IOpinionService _opinionService;


    /// <summary>
    /// It creates a opinionController
    /// </summary>
    /// <param name="logger">used for logging</param>
    /// <param name="opinionService">used for dealing with the opinion data</param>
    public OpinionesController(ILogger<OpinionesController> logger, IOpinionService opinionService)
    {
        _logger = logger;
        _opinionService = opinionService;
    }

    // [HttpGet]
    // [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OpinionDTO))]
    // public ActionResult<OpinionDTO> Get()
    // {
    //     return Ok(_opinionService.GetAll());
    // }

    // [HttpGet("{Id}")]
    // [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OpinionDTO))]
    // [ProducesResponseType(StatusCodes.Status404NotFound)]
    // public ActionResult<OpinionDTO> Get(int Id)
    // {
    //     OpinionDTO result = _opinionService.GetByID(Id);

    //     if (result == null)
    //         return NotFound();

    //     return Ok(result);

    // }


    // [HttpDelete("{Id}")]
    // [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OpinionDTO))]
    // [ProducesResponseType(StatusCodes.Status404NotFound)]
    // public ActionResult<OpinionDTO> Delete(int Id)
    // {
    //     OpinionDTO result = _opinionService.GetByID(Id);

    //     if (result == null)
    //         return NotFound();

    //     _opinionService.Delete(Id);

    //     return Ok(result);

    // }


    /// <summary>
    /// Creates an Opinion
    /// </summary>
    /// <param name="baseOpinion">the created product <see cref="BaseOpinionDTO"/></param>
    /// <returns>Returns the created product <see cref="OpinionDTO"/></returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OpinionDTO))]
    public ActionResult<OpinionDTO> Post([FromBody] BaseOpinionDTO baseOpinion)
    {

        return Ok(_opinionService.Add(baseOpinion));
    }

    // [HttpPut("{Id}")]
    // [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OpinionDTO))]
    // public ActionResult<OpinionDTO> Put([FromBody] BaseOpinionDTO baseOpinion, int Id)
    // {

    //     return Ok(_opinionService.Modify(baseOpinion, Id));
    // }

}
