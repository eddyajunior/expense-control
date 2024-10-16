using ExpenseControl.Application.Expenses.Interfaces;
using ExpenseControl.Application.Expenses.Mappers;
using ExpenseControl.Application.Expenses.Requests;
using ExpenseControl.Domain.Expense.Interfaces;

namespace ExpenseControl.Application.Expenses.AppServices
{
    public class ExpenseAppService : IExpenseAppService
    {
        private readonly IExpenseService _expenseService;

        public ExpenseAppService(IExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        public void AddNewExpense(AddNewExpenseRequest request)
        {
            var entity = ExpenseMapper.ConvertRequestToEntity(request);
            _expenseService.AddExpense(entity);
        }
    }
}
