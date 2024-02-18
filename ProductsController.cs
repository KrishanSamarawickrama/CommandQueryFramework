using CommandQueryFramework.Commands;
using CommandQueryFramework.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CommandQueryFramework;

[Route("api/[controller]")]
[ApiController]
public class ProductsController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        var products = await mediator.Send(new GetAllProductsQuery());
        return Ok(products);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody] CreateProductCommand command)
    {
        var product = await mediator.Send(command);
        return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
    }
}