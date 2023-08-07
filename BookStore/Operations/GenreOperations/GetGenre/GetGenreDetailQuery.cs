using AutoMapper;
using BookStore.BsDbContext;

namespace BookStore.Operations.GenreOperations.GetGenre
{
    public class GetGenreDetailQuery
    {
        public int GenrId { get; set; }

        public readonly BookStoreDbContext _dbcontext;
        public readonly IMapper _mapper;
        public GetGenreDetailQuery(BookStoreDbContext dbcontext, IMapper mapper)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
        }

        public GenreDetailWiewModel Handle()
        {
            var genre = _dbcontext.Genres.SingleOrDefault(x => x.IsActive && x.Id == GenrId);

            if (genre is null)
                throw new InvalidOperationException("connot found");

            return _mapper.Map<GenreDetailWiewModel>(genre);
        }

    }

    public class GenreDetailWiewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
}
