using System.Net.Sockets;

namespace WebTicket.Models
{
    public class EventViewModel
    {
        public int Id { get; set; }
        public DateTime FechaEvento { get; set; }
        public string Lugar { get; set; }
        public int NEntrada { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public bool IsDeleted { get; set; }
        //public ICollection<Ticket> Tickets { get; set; }
    }

    //public class Ticket
    //{
    //    public int Id { get; set; }
    //    public string BuyerName { get; set; }
    //    public string BuyerEmail { get; set; }
    //    public int EventId { get; set; }

    //    // Navigation property to associate Ticket with the Event
    //    //public Event Event { get; set; }
    //}
}
