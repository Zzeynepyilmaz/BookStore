using FluentValidation;

namespace BookStore.Operations.BookOperations.GetBook
{
    public class GetBookDetailQueryValidator : AbstractValidator<GetBookDetailQuery>
    {
        public GetBookDetailQueryValidator()
        {
            RuleFor(query => query.BookId).GreaterThan(0);

        }
    }
}
