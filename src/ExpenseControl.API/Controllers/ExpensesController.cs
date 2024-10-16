using ExpenseControl.Application.Expenses.Interfaces;
using ExpenseControl.Application.Expenses.Requests;
using ExpenseControl.Application.Expenses.Responses;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseControl.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpensesController : ControllerBase
    {
        private readonly IExpenseAppService _expenseAppService;

        public ExpensesController(IExpenseAppService expenseAppService)
        {
            _expenseAppService = expenseAppService;
        }

        [HttpPost]
        public ActionResult<ExpenseAddedResponse> Post([FromBody] AddNewExpenseRequest request)
        {
            _expenseAppService.AddNewExpense(request);

            return new ExpenseAddedResponse
            {
                Success = true
            };
        }
    }
}
