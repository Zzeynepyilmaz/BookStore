using AutoMapper;
using BookStore.BsDbContext;

namespace BookStore.Operations.GenreOperations.GetGenre
{
    public class GetGenresQuery
    {
        public readonly BookStoreDbContext _dbcontext;
        public readonly IMapper _mapper;
        public GetGenresQuery(BookStoreDbContext dbcontext, IMapper mapper)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
        }

        public List<GenreWiewModel> Handle()
        {
            var genres = _dbcontext.Genres.Where(x => x.IsActive).OrderBy(x => x.Id);
            List<GenreWiewModel> returnobj = _mapper.Map<List<GenreWiewModel>>(genres);
            return returnobj;
        }
    }

    public class GenreWiewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
}
