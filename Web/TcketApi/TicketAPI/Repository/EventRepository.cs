using Microsoft.EntityFrameworkCore;
using TicketAPI.Data;
using TicketAPI.Models;
using Microsoft.Extensions.Logging;

namespace TicketAPI.Repository
{
    public class EventRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<EventRepository> _logger;

        
        public EventRepository(ApplicationDbContext context, ILogger<EventRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IEnumerable<Event>> GetEventsAsync()
        {
            

            try
            {
                _logger.LogInformation("Getting all products");

                return await _context.Events.Where(e => !e.IsDeleted).ToListAsync();

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error getting all items: {0}", ex.Message);

                _logger.LogInformation(ex.Message);

                return null;
            }
            
        }

        public async Task<Event> GetEventByIdAsync(int id)
        {
            try
            {
                _logger.LogInformation("Getting by ID");

                return await _context.Events.FirstOrDefaultAsync(e => e.Id == id && !e.IsDeleted);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error getting all items: {0}", ex.Message);

                _logger.LogInformation(ex.Message);

                return null;
            }
            
        }

        public async Task<Event> AddEventAsync(Event evento)
        {
            try
            {
                _context.Events.Add(evento);
                await _context.SaveChangesAsync();
                _logger.LogInformation("Add event");
                return evento;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error getting all items: {0}", ex.Message);

                _logger.LogInformation(ex.Message);

                return null;
            }
           
        }


        public async Task UpdateEventAsync(int eventId, EventUpdate eventUpdateDto)
        {
            try
            {
                var eventToUpdate = await _context.Events.FindAsync(eventId);

                if (eventToUpdate != null)
                {
                    eventToUpdate.FechaEvento = eventUpdateDto.Date;
                    await _context.SaveChangesAsync();

                    _logger.LogInformation("update event");
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

      

        public async Task DeleteEventAsync(int eventId)
        {
            var eventToDelete = await _context.Events.FindAsync(eventId);

            try
            {
                if (eventToDelete != null)
                {
                    eventToDelete.IsDeleted = true;
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }

            
        }
    }
}
