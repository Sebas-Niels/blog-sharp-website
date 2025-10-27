using BlogSharpWebsite.DataAccessLibrary.Interfaces;
using BlogSharpWebsite.DataAccessLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using BlogSharpWebsite.DataAccessLibrary.Tools;
using System.Reflection.Metadata;

namespace BlogSharpWebsite.DataAccessLibrary.SqlServer
{
    public class AuthorDao : BaseDao, IAuthorDao
    {
        public AuthorDao(string connectionString) : base(connectionString)
        {
        }

        public int Create(Author author)
        {
            var query = "INSERT INTO Author (Email, BlogTitle, PasswordHash)" +
                "OUTPUT INSERTED.Id" +
                "VALUES (@Email, @BlogTitle, @PasswordHash);";
            var passwordHash = BCryptTool.HashPassword(author.PasswordHash);
            using var connection = CreateConnection();
            return connection.QuerySingle<int>(query, new
            {
                Email = author.Email,
                BlogTitle = author.BlogTitle,
                PasswordHash = passwordHash
            });
        }

//        {​
//  var query = "INSERT INTO Author (Email, BlogTitle, PasswordHash) ​
//     OUTPUT INSERTED.Id ​
//     VALUES (@Email, @BlogTitle, @PasswordHash);";​

//  var passwordHash = BCryptTool.HashPassword(author.Password);​

//  using var connection = CreateConnection();​

//  return connection.QuerySingle<int>(query, ​
//    new { Email = entity.Email, BlogTitle = entity.BlogTitle, ​
//        PasswordHash = passwordHash
//    }); //can be simplified​
//}

public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> GetAll()
        {
            var query = "SELECT * FROM Author";
            using var connection = CreateConnection();
            return connection.Query<Author>(query).ToList();
            throw new NotImplementedException();
        }

        public Author? GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Author author)
        {
            throw new NotImplementedException();
        }
    }
}
