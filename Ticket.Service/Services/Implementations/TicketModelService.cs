
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
            bool found = false;
            int startIndex = 0;
            int endIndex = _ticketModels.Count - 1;
            while (startIndex <= endIndex)
            {
                int Middle = (startIndex + endIndex) / 2;
                if (_ticketModels[Middle].Id == id)
                {
                    Console.WriteLine(_ticketModels[Middle]);
                    found = true;
                    break;
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
            if (!found)
            {
                Console.WriteLine("This ticket does not exist");
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

            int startIndex = 0;
            int endIndex = _ticketModels.Count - 1;
            bool found = false;
            while (startIndex <= endIndex)
            {
                int Middle = (startIndex + endIndex) / 2;
                if (_ticketModels[Middle].Id == id)
                {
                    _ticketModels.RemoveAt(Middle);
                    found = true;
                    Console.WriteLine("Removed successfully!");
                    break;

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
            if (!found)
            {
                Console.WriteLine("This ticket does not exist");
            }
        }

        public void Update()
        {
            Console.WriteLine("Input Id:");
            int.TryParse(Console.ReadLine(), out int id);

            int startIndex = 0;
            int endIndex = _ticketModels.Count - 1;
            bool found = false;
            while (startIndex <= endIndex)
            {
                int Middle = (startIndex + endIndex) / 2;
                if (_ticketModels[Middle].Id == id)
                {
                    Console.WriteLine("Add name:");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Add price:");
                    double.TryParse(Console.ReadLine(), out double Price);
                    _ticketModels[Middle].Name = Name;
                    _ticketModels[Middle].Price = Price;
                    _ticketModels[Middle].UpdatedAt = DateTime.UtcNow.AddHours(4);
                    found = true;
                    Console.WriteLine("Updated successfully!");
                    break;
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
            if (!found)
            {
                Console.WriteLine("This ticket does not exist");
            }

        }
    }
}
