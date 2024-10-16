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
        [ProducesResponseType(typeof(ExpenseAddedResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ExpenseAddedResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ExpenseAddedResponse), StatusCodes.Status500InternalServerError)]
        public ActionResult<ExpenseAddedResponse> Post([FromBody] AddNewExpenseRequest request)
        {
            return _expenseAppService.AddNewExpense(request);
        }
    }
}
