using static GraphQLPractice.Services.Query;

namespace GraphQLPractice.Repositories
{
    public class Repository
    {
        public Task<List<Book>> GetBooks()
        {
            return Task.FromResult(new List<Book>());
        }

        public Task<List<Book>> GetBook(string bookName, string author)
        {
            return Task.FromResult(new List<Book>() { new Book(Guid.NewGuid(), bookName, new Author(Guid.NewGuid(), author)) });
        }
    }
}
