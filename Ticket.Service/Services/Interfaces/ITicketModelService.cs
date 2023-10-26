
using Ticket.Core.Models;

namespace Ticket.Service.Services.Interfaces
{
    public interface ITicketModelService
    {
        public void Create();
        public void GetAll();
        public void Get();
        public void Remove();
        public void Update();

    }
}
