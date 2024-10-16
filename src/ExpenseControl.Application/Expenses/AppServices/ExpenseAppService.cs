using ExpenseControl.Application.Expenses.Interfaces;
using ExpenseControl.Application.Expenses.Mappers;
using ExpenseControl.Application.Expenses.Requests;
using ExpenseControl.Application.Expenses.Responses;
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

        public ExpenseAddedResponse AddNewExpense(AddNewExpenseRequest request)
        {   
            try
            {
                var entity = ExpenseMapper.ConvertRequestToEntity(request);
                _expenseService.AddExpense(entity);

                return new ExpenseAddedResponse
                {
                    Success = true
                };
            }
            catch (Exception ex)
            {
                return new ExpenseAddedResponse
                {
                    Success = false,
                    Exception = ex,
                    Message = ex.Message
                };
            }
        }
    }
}
