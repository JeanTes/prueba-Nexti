using Microsoft.AspNetCore.Mvc;
using System.Net;
using TicketAPI.Models;
using TicketAPI.Repository;

namespace TicketAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : Controller
    {
        private readonly EventRepository _repository;

        public EventController(EventRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("All")]
        public async Task<IEnumerable<Event>> Get()
        {
            try
            {
                return await _repository.GetEventsAsync();
            }
            catch (Exception ex)
            {

                return null;
            }
            
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var evento = await _repository.GetEventByIdAsync(id);

                if (evento == null)
                {
                    return NotFound();
                }

                return Ok(evento);
            }
            catch (Exception ex)
            {

                throw;
                
            }
           
        }

        [HttpPost]
        [Route("Insertar")]
        public async Task<IActionResult> Post(Event evento)
        {
            try
            {
                await _repository.AddEventAsync(evento);
                return CreatedAtAction(nameof(Get), new { id = evento.Id }, evento);
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }

        //[HttpPut]
        //[Route("Modificar/{id}")]
        //public async Task<IActionResult> Put(int id, Event evento)
        //{
        //    try
        //    {
        //        if (id != evento.Id)
        //        {
        //            return BadRequest();
        //        }

        //        await _repository.UpdateEventAsync(evento);
        //        return NoContent();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
            
        //}

        [HttpPut]
        [Route("Modificar/{id}")]
        public async Task<IActionResult> Put(int id, EventUpdate eventUpdateDto)
        {
            try
            {
                var existingEvent = await _repository.GetEventByIdAsync(id);

                if (existingEvent == null)
                {
                    return NotFound();
                }

                await _repository.UpdateEventAsync(id, eventUpdateDto);
                return NoContent();
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        [HttpDelete]
        [Route("Eliminar/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var evento = await _repository.GetEventByIdAsync(id);

                if (evento == null)
                {
                    return NotFound();
                }

                await _repository.DeleteEventAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }
    }
}
