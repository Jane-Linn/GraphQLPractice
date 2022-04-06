using static GraphQLPractice.Services.Query;

namespace GraphQLPractice.Repositories
{
    public class Repository
    {
        public Task<List<Book>> GetBooks()
        {
            return Task.FromResult(new List<Book>() 
            {
                new Book(Guid.NewGuid(), $"bookName-1", new Author(Guid.NewGuid(), $"author-1")) , 
                new Book(Guid.NewGuid(), $"bookName-1", new Author(Guid.NewGuid(), $"author-1"))
            });
        }

        public Task<List<Book>> GetBook(int count)
        {
            return Task.FromResult(Enumerable.Range(1, 1 + count)
                .Select(index => new Book(Guid.NewGuid(), $"bookName-{index}", new Author(Guid.NewGuid(), $"author-{index}"))).ToList());
        }
    }
}
