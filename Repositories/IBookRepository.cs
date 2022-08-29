using API_Basic.Model;

namespace API_Basic.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> Get();
        Task<Book> GetById(int id);
        Task<Book> Create (Book book);
        Task Update (Book book);
        Task Delete (int id);
    }
}
