using BookStore.BsDbContext;

namespace BookStore.Operations.BookOperations.DeleteBook
{
    public class DeleteBookCommand
    {
        private readonly BookStoreDbContext _dbContext;
        public int BookId { get; set; }
        public DeleteBookCommand(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Handle()
        {

            var books = _dbContext.Books.SingleOrDefault(b => b.Id == BookId);
            if (books is null)
                throw new InvalidOperationException("Silinecek Kitap Bulunamadı");

            _dbContext.Books.Remove(books);
            _dbContext.SaveChanges();
        }
    }
}
