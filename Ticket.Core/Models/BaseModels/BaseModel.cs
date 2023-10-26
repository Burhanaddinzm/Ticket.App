
namespace Ticket.Core.Models.BaseModels
{
    public abstract class BaseModel
    {
        private static int _id;
        public  int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public BaseModel()
        {
            _id++;
            Id = _id;
        }
    }
}
