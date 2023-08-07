using AutoMapper;
using BookStore.BsDbContext;
using BookStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Operations.BookOperations.GetBook
{
    public class GetBooksQuery
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetBooksQuery(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public List<BooksViewModel> Handle()
        {
            var bookList = _dbContext.Books.Include(x => x.Genre).Where(x => x.IsPublished == true).Include(x => x.Author).OrderBy(x => x.Id).ToList();
            List<BooksViewModel> vm = _mapper.Map<List<BooksViewModel>>(bookList);

            return vm;
        }

        public class BooksViewModel
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Genre { get; set; }
            public int PageCount { get; set; }
            public string PublisDate { get; set; }

        }

    }
}
