
using Ticket.Core.Models;
using Ticket.Service.Services.Interfaces;

namespace Ticket.Service.Services.Implementations
{
    public class TicketModelService : ITicketModelService
    {
        List<TicketModel> _ticketModels = new List<TicketModel>();

        public void Create()
        {
            Console.WriteLine("Add name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Add price:");
            double.TryParse(Console.ReadLine(), out double Price);
            TicketModel ticketModel = new TicketModel(Name, Price);
            ticketModel.CreatedAt = DateTime.UtcNow.AddHours(4);
            _ticketModels.Add(ticketModel);
            Console.WriteLine("Created successfully!");
        }

        public void Get()
        {
            Console.WriteLine("Input Id:");
            int.TryParse(Console.ReadLine(), out int id);
            TicketModel ticket = GetById(id);
            if (ticket==null)
            {
                Console.WriteLine("Not Found!");
            }
            else
            {
                Console.WriteLine(ticket);
            }
        }

        public void GetAll()
        {
            foreach (TicketModel ticketModel in _ticketModels)
            {
                Console.WriteLine(ticketModel);
            }
        }

        public void Remove()
        {
            Console.WriteLine("Input Id:");
            int.TryParse(Console.ReadLine(), out int id);

            TicketModel ticket = GetById(id);

            if (ticket == null)
            {
                Console.WriteLine("Not Found!");
            }
            else
            {
                _ticketModels.Remove(ticket);
            }

        }

        public void Update()
        {
            Console.WriteLine("Input Id:");
            int.TryParse(Console.ReadLine(), out int id);

            TicketModel ticket = GetById(id);
            if (ticket == null)
            {
                Console.WriteLine("Not Found!");
            }
            else
            {
                Console.WriteLine("Add name:");
                string Name = Console.ReadLine();
                Console.WriteLine("Add price:");
                double.TryParse(Console.ReadLine(), out double Price);
                ticket.Name = Name;
                ticket.Price = Price;
                ticket.UpdatedAt = DateTime.UtcNow.AddHours(4);
            }

        }

        private TicketModel GetById(int id)
        {
            int startIndex = 0;
            int endIndex = _ticketModels.Count - 1;
            while (startIndex <= endIndex)
            {
                int Middle = (startIndex + endIndex) / 2;
                if (_ticketModels[Middle].Id == id)
                {
                    return _ticketModels[Middle];
                }
                else if (_ticketModels[Middle].Id < id)
                {
                    startIndex = Middle + 1;
                }
                else
                {
                    endIndex = Middle - 1;
                }

            }
            return null;
        }
    }
}
