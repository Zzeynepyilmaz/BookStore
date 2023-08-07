using BookStore.BsDbContext;
using BookStore.Entities;

namespace BookStore.Operations.GenreOperations.CreateGenre
{
    public class CreateGenreCommand
    {
        public CreateGrenreModel Model { get; set; }
        private readonly BookStoreDbContext _dbContext;


        public CreateGenreCommand(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public void Handle()
        {
            var genre = _dbContext.Genres.SingleOrDefault(g => g.Name == Model.Name);

            if (genre is not null)
                throw new InvalidOperationException("Bu Kitap Türü Ekli");
            genre = new Genre();
            genre.Name = Model.Name;
            _dbContext.Genres.Add(genre);
            _dbContext.SaveChanges();
        }

    }
    public class CreateGrenreModel
    {
        public string Name { get; set; }
    }
}
}
