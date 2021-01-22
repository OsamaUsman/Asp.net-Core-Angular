using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerApp.Models;
using ServerApp.Repository.Controller;
using ServerApp.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : AppController<Product, ProductRepository>
    {
        ProductRepository _pr;
        public ProductsController(ProductRepository pr) : base(pr)
        {
            _pr = pr;
        }

        [HttpGet("rel/{id}")]
        public async Task<ActionResult<Product>> GetRelated(int id)
        {
            var entity = await _pr.GetRelated(id);
            if (entity == null)
            {
                return NotFound();
            }
            return entity;
        }
        [HttpGet("rel")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts(string category, string search,
             bool related = false)
        {
            return await _pr.GetWithRelated(category, search, related);
        }

    }
}
