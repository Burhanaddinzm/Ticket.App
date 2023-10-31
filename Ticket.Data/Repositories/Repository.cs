
namespace Ticket.Data.Repositories
{
    public class Repository<T>
    {
        List<T> datas = new List<T>();

        public void Add(T data)
        {
            datas.Add(data);
        }

        public List<T> GetAll()
        {
            return datas;
        }
        public T Get(Func<T, bool> func)
        {
            return datas.FirstOrDefault(func);
        }

        public void Remove(T data)
        {
            datas.Remove(data);
        }
    }
}
