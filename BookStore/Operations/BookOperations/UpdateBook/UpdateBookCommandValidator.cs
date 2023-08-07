using FluentValidation;

namespace BookStore.Operations.BookOperations.UpdateBook
{
    public class UpdateBookCommandValidator
    {
        public UpdateBookCommandValidator()
        {
            RuleFor(command => command.BookId).GreaterThan(0);
            RuleFor(command => command.Model.GenreId).GreaterThan(0);
            RuleFor(command => command.Model.Title).NotEmpty().MinimumLength(4).NotNull();
        }
    }
}
