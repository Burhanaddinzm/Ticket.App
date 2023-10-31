
namespace Ticket.Core.Models.BaseModels
{
    public abstract class BaseModel
    {
        //Base model has Id,CreatedAt and UpdatedAt properties
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
