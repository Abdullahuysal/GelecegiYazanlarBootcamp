using DapperHomeWork.Model;
using DapperHomeWork.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperHomeWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductRepository _productRepository;
       
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet("getproducts")]
        public IActionResult GetProducts()
        {
            var result = _productRepository.GetAll();
            return Ok(result);
        }
        [HttpGet("getproductbyid")]
        public IActionResult GetProductsById(int id)
        {
            var result = _productRepository.GetById(id);
            return Ok(result);
        }
        [HttpPost("addproduct")]
        public IActionResult Add(Product product)
        {
            var message= _productRepository.Add(product);
            return Ok(message);
        }
        [HttpPost("deleteproduct")]
        public IActionResult delete(int ProductId)
        {
            var message = _productRepository.Delete(ProductId);
            return Ok(message);
        }
    }
}
