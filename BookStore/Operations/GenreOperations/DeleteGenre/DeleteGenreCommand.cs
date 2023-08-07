using BookStore.BsDbContext;

namespace BookStore.Operations.GenreOperations.DeleteGenre
{
    public class DeleteGenreCommand
    {
        private readonly BookStoreDbContext _dbcontext;

        public int GenreId { get; set; }

        public DeleteGenreCommand(BookStoreDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void Handle()
        {
            var genre = _dbcontext.Genres.SingleOrDefault(g => g.Id == GenreId);
            if (genre is null)
                throw new InvalidOperationException("connot found");

            _dbcontext.Genres.Remove(genre);
            _dbcontext.SaveChanges();

        }
    }
}
