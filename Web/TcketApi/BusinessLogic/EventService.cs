using Microsoft.EntityFrameworkCore;
using TcketApi.Data;
using TcketApi.Models;

namespace TcketApi.BusinessLogic
{
    public class EventService
    {
        private readonly Ticket _context;

        public EventService(Ticket context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Event>> GetAllEventsAsync()
        {
            return await _context.Events.ToListAsync();
        }

        public async Task<Event> GetEventByIdAsync(int id)
        {
            return await _context.Events.FindAsync(id);
        }

        public async Task<Event> AddEventAsync(Event eventToAdd)
        {
            _context.Events.Add(eventToAdd);
            await _context.SaveChangesAsync();
            return eventToAdd;
        }

        public async Task<Event> UpdateEventAsync(Event updatedEvent)
        {
            _context.Entry(updatedEvent).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return updatedEvent;
        }

        public async Task DeleteEventAsync(int id)
        {
            var eventToDelete = await _context.Events.FindAsync(id);
            if (eventToDelete == null)
            {
                throw new ArgumentException("Event not found");
            }

            _context.Events.Remove(eventToDelete);
            await _context.SaveChangesAsync();
        }

    }
}
