using ExpenseControl.Application.Expenses.Requests;
using ExpenseControl.Domain.Expense;

namespace ExpenseControl.Application.Expenses.Mappers
{
    public static class ExpenseMapper
    {
        public static ExpenseEntity ConvertRequestToEntity(AddNewExpenseRequest request)
        {
            return new ExpenseEntity(
                request.Description,
                request.Date,
                request.Amount
            );
        }
    }
}
