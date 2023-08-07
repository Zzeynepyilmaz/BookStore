using FluentValidation;

namespace BookStore.Operations.GenreOperations.GetGenre
{
    public class GetGenreDetailQueryValidator : AbstractValidator<GetGenreDetailQuery>
    {
        public GetGenreDetailQueryValidator()
        {
            RuleFor(query => query.GenrId).GreaterThan(0);

        }
    }
}
