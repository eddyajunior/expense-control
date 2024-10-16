using ExpenseControl.Application.Expenses.Requests;
using ExpenseControl.Application.Expenses.Responses;

namespace ExpenseControl.Application.Expenses.Interfaces
{
    public interface IExpenseAppService
    {
        ExpenseAddedResponse AddNewExpense(AddNewExpenseRequest request);
    }
}
