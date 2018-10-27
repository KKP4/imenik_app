using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using imenik_app.imenikDB;
using imenik.Controllers.Resources;
using imenik_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;




namespace imenik_app.Controllers
{
    [Route("api/imenik")]

    public class ImenikController : Controller
    {
        private readonly IMapper mapper;
        private readonly ImenikDbContext context;
        public ImenikController(IMapper mapper, ImenikDbContext context)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ImenikResources>> GetImenik(ImenikResources imenikResource)
        {
            var imenik = await context.Imeniki.ToListAsync();
            
            return mapper.Map<IEnumerable<Imenik>, IEnumerable<ImenikResources>>(imenik);

            

        }
       
        [HttpPost]
        public async Task<IActionResult> CreateImenik([FromBody] ImenikResources imenikResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var imenik = mapper.Map<ImenikResources, Imenik>(imenikResource);
            Console.Write(imenik);

            context.Imeniki.Add(imenik);
            await context.SaveChangesAsync();
            return Ok(imenik);

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateImenik(int id, [FromBody] ImenikResources imenikResource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var imenik = await context.Imeniki.FindAsync(id);
            if (imenik == null)
                return NotFound();
            Console.Write(imenik);
            mapper.Map<ImenikResources, Imenik>(imenikResource, imenik);
            Console.Write(imenik);
            await context.SaveChangesAsync();
            return Ok(imenik);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetImenik(int id)
        {
            var imenik = await context.Imeniki.FindAsync(id);
            if (imenik == null) { 
                return NotFound();
            }
            var imenikResource = mapper.Map<Imenik, ImenikResources>(imenik);
            return Ok(imenikResource);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImenik(int id)
        {
            var imenik = await context.Imeniki.FindAsync(id);
            if (imenik == null)
                return NotFound();
            context.Remove(imenik);
            await context.SaveChangesAsync();
            return Ok(id);
        }
    }
}
