using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reservas.BData;
using Reservas.BData.Data.Entity;

namespace HotelApp.Server.Controllers
{
    [ApiController]
    [Route("api/Habitacion")]
    public class HabitacionesController : ControllerBase
    {
        private readonly Context context;

        public HabitacionesController(Context context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Habitacion>>> Get()
        {
            return await context.Habitaciones.ToListAsync();
        }
        
        [HttpPost] 
        public async Task<ActionResult> Post(Habitacion habitacion)
        {
            context.Add(habitacion);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]

        public async Task<ActionResult> Put(Habitacion habitacion,int nrohab)
        {
            var habitacion1 = await context.Habitaciones.FirstOrDefaultAsync(c => c.Nhab==nrohab);

            if (habitacion1 is null)
            {
                return NotFound("No se encontro la habitacion para ser actualizada");
            }
            context.Update(habitacion1);
            await context.SaveChangesAsync();
            return Ok(habitacion);
        }

        [HttpDelete]

        public async Task<ActionResult> Delete(int nrohab)
        {
            var habitacion = await context.Habitaciones.FirstOrDefaultAsync(c => c.Nhab==nrohab);

            if (habitacion is null)
            {
                return NotFound("No encontro la habitacion para ser borrada");
            }

            context.Remove(habitacion);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
