
using Ticket.Core.Models.BaseModels;

namespace Ticket.Core.Models
{
    public class TicketModel : BaseModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public TicketModel(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} Price:{Price} CreatedAt:{CreatedAt} UpdatedAt:{UpdatedAt}";
        }
    }
}
