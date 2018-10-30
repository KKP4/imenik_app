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
        public async Task<IEnumerable<KontaktResources>> GetKontakti(KontaktResources imenikResource)
        {
            var kontakti = await context.Kontakti.ToListAsync();
            
            return mapper.Map<IEnumerable<Kontakt>, IEnumerable<KontaktResources>>(kontakti);

            

        }
       
        [HttpPost]
        public async Task<IActionResult> CreateKontakt([FromBody] KontaktResources kontaktResource)
        {
            if (!ModelState.IsValid) { 
                return BadRequest(ModelState);
            }

            var kontakt = mapper.Map<KontaktResources, Kontakt>(kontaktResource);
            

            context.Kontakti.Add(kontakt);
            await context.SaveChangesAsync();
            return Ok(kontakt);

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateImenik(int id, [FromBody] KontaktResources imenikResource)
        {
            if (!ModelState.IsValid) { 
                return BadRequest(ModelState);
            }
            var kontakt = await context.Kontakti.FindAsync(id);
            if (kontakt == null)
                return NotFound();
            mapper.Map<KontaktResources, Kontakt>(imenikResource, kontakt);
            
            await context.SaveChangesAsync();
            return Ok(kontakt);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetKontakt(int id)
        {
            var kontakt = await context.Kontakti.FindAsync(id);
            if (kontakt == null) { 
                return NotFound();
            }
            var kontaktResource = mapper.Map<Kontakt, KontaktResources>(kontakt);
            return Ok(kontaktResource);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKontakt(int id)
        {
            var kontakt = await context.Kontakti.FindAsync(id);
            if (kontakt == null)
                return NotFound();
            context.Remove(kontakt);
            await context.SaveChangesAsync();
            return Ok(id);
        }
    }
}
