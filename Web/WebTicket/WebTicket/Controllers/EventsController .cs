using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WebTicket.Models;
using WebTicket.services;

namespace WebTicket.Controllers
{
    public class EventsController : Controller
    {

        private readonly EventService _eventService;       

        public EventsController(EventService eventService)
        {
            _eventService = eventService; 

        }

        
        public async Task<IActionResult> Index()
        {
            var events = await _eventService.GetEventsAsync();

            return View(events);
        }

        // GET: Events/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var eventItem = await _eventService.GetByIdAsync(id);
            if (eventItem == null)
            {
                return NotFound();
            }

            return View(eventItem);
        }

        // GET: Events/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Events/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EventViewModel eventToAdd)
        {
            if (ModelState.IsValid)
            {
                await _eventService.CreateEvent(eventToAdd);
                return RedirectToAction(nameof(Index));
            }

            return View(eventToAdd);
        }


        // GET: Events/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var eventItem = await _eventService.GetByIdAsync(id);
            if (eventItem == null)
            {
                return NotFound();
            }

            return View(eventItem);
        }

        // POST: Events/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EventViewModel eventToUpdate)
        {
            if (ModelState.IsValid)
            {
                await _eventService.UpdateEventAsync(id, eventToUpdate);
                return RedirectToAction(nameof(Index));
            }

            return View(eventToUpdate);
        }


        // GET: Events/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var eventItem = await _eventService.GetByIdAsync(id);
            if (eventItem == null)
            {
                return NotFound();
            }

            return View(eventItem);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _eventService.DeleteEventAsync(id);
            return RedirectToAction(nameof(Index));
        }



    }
}
