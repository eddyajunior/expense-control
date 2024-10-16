using ExpenseControl.Application.Expenses.Requests;

namespace ExpenseControl.Application.Expenses.Interfaces
{
    public interface IExpenseAppService
    {
        void AddNewExpense(AddNewExpenseRequest request);
    }
}
