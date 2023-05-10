using WebTicket.Models;

namespace WebTicket.services
{
    public class EventService
    {
        private readonly HttpClient _httpClient;

        public EventService(HttpClient httpClient)
        {
            

            _httpClient = httpClient;
        }

        public async Task<IEnumerable<EventViewModel>> GetEventsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EventViewModel>>("/api/Event/All");
        }

        public async Task<EventViewModel> GetByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<EventViewModel>($"api/Event/GetById/{id}");
        }

        public async Task<EventViewModel> CreateEvent(EventViewModel evento)
    {
            //await _httpClient.PostAsJsonAsync("api/Event/Insertar", evento);

            var response = await _httpClient.PostAsJsonAsync("api/Event/Insertar", evento);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<EventViewModel>();
        }

        public async Task<EventViewModel> UpdateEventAsync(int id, EventViewModel evento)
    {
            //await _httpClient.PutAsJsonAsync($"api/Event/Modificar/{id}", evento);

            var response = await _httpClient.PutAsJsonAsync($"api/Event/Modificar/{id}", evento);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<EventViewModel>();
        }

        public async Task DeleteEventAsync(int id)
        {
            //await _httpClient.DeleteAsync($"api/Event/Eliminar/{id}");

            var response = await _httpClient.DeleteAsync($"api/Event/Eliminar/{id}");
            response.EnsureSuccessStatusCode();
        }

    }
}
