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
        //debuggear con swagger
    }
}
