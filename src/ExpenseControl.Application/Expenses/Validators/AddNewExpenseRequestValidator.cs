using ExpenseControl.Application.Expenses.Requests;
using FluentValidation;

namespace ExpenseControl.Application.Expenses.Validators
{
    public class AddNewExpenseRequestValidator : AbstractValidator<AddNewExpenseRequest>
    {
        public AddNewExpenseRequestValidator()
        {
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Description is required")
                .MaximumLength(100).WithMessage("Description length exceeded");

            RuleFor(x => x.Amount)
                .GreaterThan(0).WithMessage("Amount should be greater than zero");

            RuleFor(x => x.Date)
                .Must(BeAValidDate).WithMessage("Invalid date");
        }

        private bool BeAValidDate(DateTime date)
        {
            if (date > DateTime.Now)
                return false;

            if (date > DateTime.Now.AddDays(-1))
                return false;

            var newDate = date.ToString();
            return DateTime.TryParse(newDate, out date);
        }
    }
}
