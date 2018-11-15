using System;
using System.Collections.Generic;
using BusinessLayer.Models;
using BusinessLayer.Services;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        readonly IGenericServices<ShoppingCartDto> genericServices;

        public ShoppingCartController(IGenericServices<ShoppingCartDto> genericServices)
        {
            this.genericServices = genericServices;
        }

        // GET: api/ShoppingCart
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ShoppingCart/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            this.genericServices.Add(new ShoppingCartDto(Guid.NewGuid(), DateTime.Now, "Carapace"));
            return "Cart";
        }

        // POST: api/ShoppingCart
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/ShoppingCart/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
