using Catalog.API.Products.CreateProduct;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [Route("[controller]")]
    public class ProductsController(ISender sender) : ControllerBase
    {
        [HttpPost]
        public async Task<IResult> CreateProduct(CreateProductCommand command)
        {
            var result = await sender.Send(command);

            return Results.Created($"/products/{result.Id}", result.Id);
        }
    }
}
