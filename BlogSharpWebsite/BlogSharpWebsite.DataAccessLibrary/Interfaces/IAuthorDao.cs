using BlogSharpWebsite.DataAccessLibrary.Model;

namespace BlogSharpWebsite.DataAccessLibrary.Interfaces
{
    public interface IAuthorDao
    {
        Author? GetOne(int id);
        IEnumerable<Author> GetAll();
        bool Delete(int id);
        bool Update(Author author);
        int Create(Author author);
    }
}
