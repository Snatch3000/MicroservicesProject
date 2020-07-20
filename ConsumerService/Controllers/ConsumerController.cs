using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductService.Client;
using ProductService.Client.Models;

namespace ConsumerService.Controllers
{
    [Route("api/consumer")]
    [ApiController]
    public class ConsumerController : ControllerBase
    {
        private readonly IProductService _productService;

        public ConsumerController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateAsync([FromBody]ProductCreateModel model)
        {
            await _productService.CreateProductAsync(model);

            return Ok();
        }

        [HttpGet("get/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAsync(int id)
        {

            var product = await _productService.GetProductAsync(id);
           
            return Ok(product);
        }
    }
}