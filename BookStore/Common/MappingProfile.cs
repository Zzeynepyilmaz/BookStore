using AutoMapper;
using BookStore.Entities;
using BookStore.Operations.BookOperations;
using static BookStore.Operations.BookOperations.CreateBookCommand;
using static BookStore.Operations.BookOperations.GetBooksQuery;

namespace BookStore.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Book Maps
            CreateMap<CreateBookModel, Book>();
            CreateMap<Book, BookDetailViewModel>().
                ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name)).
                ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author.Name)).
                ForMember(dest => dest.PublisDate, opt => opt.MapFrom(src => src.PublisDate.ToShortDateString()));

            CreateMap<Book, BooksViewModel>().
                ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name)).
                ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author.Name)).
                ForMember(dest => dest.PublisDate, opt => opt.MapFrom(src => src.PublisDate.ToShortDateString()));

            // Genre Maps
            //CreateMap<Genre, GenreWiewModel>();
            //CreateMap<Genre, GenreDetailWiewModel>();

            //// Author Maps
            //CreateMap<Author, AuthorviewModel>();

            //CreateMap<Author, AuthorDetailViewModel>().ForMember(d => d.Birthday, opt => opt.MapFrom(src => src.Birthday.ToShortDateString()));

            //CreateMap<CreateAuthorModel, Author>().ForMember(d => d.Birthday, opt => opt.MapFrom(src => src.BirthDay.ToShortDateString()));

            //CreateMap<CreateUserModel, User>();
            //CreateMap<User, GetDetailUserQuery>();
            //CreateMap<UpdateUserModel, User>();
            //CreateMap<CreateBookModel, User>();

        }
        }

    
}
