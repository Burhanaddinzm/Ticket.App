
using Ticket.Core.Models;

namespace Ticket.Data.Repositories
{
    public class TicketRepository
    {
        List<TicketModel> _ticketModels = new List<TicketModel>();

        public void Add(TicketModel ticket)
        {
            _ticketModels.Add(ticket);
        }

        public List<TicketModel> GetAll()
        {
            return _ticketModels;
        }
    }
}
