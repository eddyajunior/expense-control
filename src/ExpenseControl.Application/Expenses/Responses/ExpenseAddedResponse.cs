using ExpenseControl.Application.Bases;

namespace ExpenseControl.Application.Expenses.Responses
{
    public class ExpenseAddedResponse : ResponseBase
    {
        public Guid Id { get; set; }
    }
}
