using HotelApp.Client.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reservas.BData;
using Reservas.BData.Data.Entity;

namespace HotelApp.Server.Controllers
{
    [ApiController]
    [Route("api/{ControllerHabitaciones}")]
    public class HabitacionesController : ControllerBase
    {
        private readonly Context context;

        public HabitacionesController(Context context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Habitacion>>> Get(int Nhab)
        {
            return await context.Habitaciones.ToListAsync();
        }
        
        [HttpPost] 
        public async Task<ActionResult<List<Habitacion>>> Post(Habitacion habitacion)
        {
            context.Add(habitacion);
            await context.SaveChangesAsync();
            return Ok(habitacion);
        }
        //debuggear con swagger
    }
}
