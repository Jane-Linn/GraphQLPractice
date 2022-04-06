using GraphQLPractice.Repositories;

namespace GraphQLPractice.Services
{
    public class Query
    {
        private Repository Repository;
        public Query(Repository repository)
        {
            Repository = repository;
        }
        public record Author(Guid Id ,string Name);
        public record Book(Guid Id, string Title, Author Author);
        public string GetHello()
        {
            //套件會幫你把Get去掉 變成t
            return "Hello";
        }

        
        public Task<List<Book>> GetBooks([Service] Repository repository)
        {
            // 雖然Qurey class 叫 GetBook 但查詢的query要指定的type name 是Book
            // 用[Service]判斷你帶入的query 和服務的關係 是不是有依賴注入 => 方法型的依賴注入
            // 別的方法不需要此服務
            return repository.GetBooks();
        }

        public Task<List<Book>> GetBooks([Service] Repository repository, int count)
        {
            return repository.GetBook(count);
        }
    }
}
