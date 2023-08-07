using FluentValidation;

namespace BookStore.Operations.BookOperations.DeleteBook
{
    public class DeleteBookCommandValidator
    {
        public DeleteBookCommandValidator()
        {
            RuleFor(command => command.BookId).GreaterThan(0);
        }
    }
}
