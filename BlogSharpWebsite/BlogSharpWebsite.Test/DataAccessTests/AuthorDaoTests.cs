using BlogSharpWebsite.DataAccessLibrary.Interfaces;
using BlogSharpWebsite.DataAccessLibrary.SqlServer;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BlogSharpWebsite.DataAccessTest;

public class AuthorDaoTests
{
    private const string connectionString = "Data Source=localhost;" +
        "Initial Catalog = BlogSharp; " +
        "Persist Security Info=True;" +
        "User ID = sa; " +
        "Password=@12tf56so;" +
        "Encrypt=True;" +
        "Trust Server Certificate=True";

    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AuthorDao_GetAll()
    {
        // Arrange
        IAuthorDao authorDao = new AuthorDao(connectionString);

        // Act
        var authors = authorDao.GetAll();

        // Assert
        Assert.That(3, Is.EqualTo(authors.Count()));

        
        
    }
}
