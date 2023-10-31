
using Ticket.Core.Models.BaseModels;

namespace Ticket.Core.Models
{
    public class TicketModel : BaseModel
    {
        //TicketModel has _id field, Name and Price properties
        private static int _id;
        public string Name { get; set; }
        public double Price { get; set; }
        //Ctor increments _id field every time TicketModel class is used and sets Id properties value
        //to _id field.Takes name and price values from TicketModelSerivce
        public TicketModel(string name, double price)
        {
            _id++;
            Id = _id;
            this.Name = name;
            this.Price = price;
        }
        //Overriding the ToString methode of this Class to show the values whenever it is called.
        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} Price:{Price} CreatedAt:{CreatedAt} UpdatedAt:{UpdatedAt}";
        }
    }
}
