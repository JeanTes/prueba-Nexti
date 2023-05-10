using Microsoft.AspNetCore.Mvc;
using TcketApi.BusinessLogic;
using TcketApi.Models;

namespace TcketApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : Controller
    {
        private readonly EventService _eventService;

        public EventsController(EventService eventService)
        {
            _eventService = eventService;
        }       

        [HttpGet]
        [Route("All")]
        public async Task<ActionResult<IEnumerable<Event>>> GetAll()
        {
            return Ok(await _eventService.GetAllEventsAsync());
        }

        [HttpGet]
        [Route("ObtenerEvent/{id}")]
        public async Task<ActionResult<Event>> ObtenerEvent(int id)
        {
            var eventItem = await _eventService.GetEventByIdAsync(id);

            if (eventItem == null)
            {
                return NotFound();
            }

            return eventItem;
        }

        [HttpPost]
        [Route("EnviarEvent")]
        public async Task<ActionResult<Event>> PostEvent(Event eventItem)
        {
            await _eventService.AddEventAsync(eventItem);
            return CreatedAtAction(nameof(ObtenerEvent), new { id = eventItem.Id }, eventItem);
        }

        [HttpPut]
        [Route("ModificaEvent/{id}")]
        public async Task<IActionResult> PutEvent(int id, Event eventItem)
        {
            if (id != eventItem.Id)
            {
                return BadRequest();
            }

            await _eventService.UpdateEventAsync(eventItem);
            return NoContent();
        }

        [HttpDelete]
        [Route("Eliminar/{id}")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            await _eventService.DeleteEventAsync(id);
            return NoContent();

        }


    }
}
