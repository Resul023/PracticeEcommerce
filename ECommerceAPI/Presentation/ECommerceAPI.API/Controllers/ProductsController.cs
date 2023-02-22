

namespace ECommerceAPI.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    readonly IMediator _mediator;
    public ProductsController(IMediator mediator)
    {
        this._mediator = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] GetAllProductQueryRequest getAllProductQueryRequest)
    {
        GetAllProductQueryResponse response = await _mediator.Send(getAllProductQueryRequest);
        return Ok(response);
    }
    [HttpGet("{Id}")]
    public async Task<IActionResult> GetById([FromRoute] GetByIdProductQueryRequest getByIdProductQueryResponse)
    {
        GetByIdProductQueryResponse response = await _mediator.Send(getByIdProductQueryResponse);
        return Ok(response);
    }
    [HttpPost()]
    public async Task<IActionResult> Create([FromBody] CreateProductCommandRequest createProductCommandRequest)
    {
        Guid response = await _mediator.Send(createProductCommandRequest);
        return Ok(response);
    }
    [HttpPut()]
    public async Task<IActionResult> Update([FromBody] UpdateCountryCommandRequest updateProductCommandRequest)
    {
        MediatR.Unit response = await _mediator.Send(updateProductCommandRequest);
        return Ok(response);
    }
    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete([FromRoute] DeleteProductCommandRequest deleteProductCommandRequest)
    {
        MediatR.Unit response = await _mediator.Send(deleteProductCommandRequest);
        return Ok(response);
    }


}
